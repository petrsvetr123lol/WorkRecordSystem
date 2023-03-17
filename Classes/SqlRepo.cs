using System;
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

        Dictionary<string, User> users = new Dictionary<string, User>();

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User(reader["Name"].ToString(), reader["Password"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return users;
        }

        public User? GetUser(string username)
        {
            User? user = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where Name=@Name";
                    cmd.Parameters.AddWithValue("Name", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(reader["Name"].ToString(), reader["Password"].ToString());
                        }
                    }
                }
                conn.Close();
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
