﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;


namespace WorkRecordSystem.Classes
{
    public class SqlRepo
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WorkRecordSystemDb;Integrated Security=True;Connect Timeout=30;Encrypt=False";


        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "select * from Users";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new User(reader["Name"].ToString()
                                             , (byte[])reader["PasswordHash"]
                                             , (byte[])reader["PasswordSalt"]
                                             , (string)reader["IsAdmin"]
                                             ) ;
                            users.Add(user);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return users;
        }


        public List<User> GetUsers(string searchString)
        {
            List<User> users = new List<User>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where Name like @Search";
                    cmd.Parameters.AddWithValue("Search", "%" + searchString + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new User(reader["Name"].ToString()
                                             , (byte[])reader["PasswordHash"]
                                             , (byte[])reader["PasswordSalt"]
                                             , (string)reader["IsAdmin"]);
                            users.Add(user);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return users;
        }

        public User? GetUser(string username)
        {
            User? user = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where Name=@Name";
                    cmd.Parameters.AddWithValue("Name", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(reader["Name"].ToString()
                                , (byte[])reader["PasswordHash"]
                                , (byte[])reader["PasswordSalt"]
                                , (string)reader["IsAdmin"]);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return user;
        }



        public void SaveUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "update Users set PasswordSalt=@Salt, PasswordHash=@Hash where Name=@Name";
                    cmd.Parameters.AddWithValue("Salt", user.PasswordSalt);
                    cmd.Parameters.AddWithValue("Hash", user.PasswordHash);
                    cmd.Parameters.AddWithValue("Name", user.Name);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void AddUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "Insert into Users(Name, PasswordHash, PasswordSalt, IsAdmin) values (@Name,@Hash,@Salt,@Role)";
                    cmd.Parameters.AddWithValue("Name", user.Name);
                    cmd.Parameters.AddWithValue("Salt", user.PasswordSalt);
                    cmd.Parameters.AddWithValue("Hash", user.PasswordHash);
                    cmd.Parameters.AddWithValue("Role", user.Role);

                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void ConvertUsersToHashed()
        {
            var users = GetUsers();
            foreach (var user in users)
            {
                SaveUser(user);
            }
        }
   

    }
}
