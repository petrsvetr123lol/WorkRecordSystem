using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;

namespace WorkRecordSystem.Classes
{
    public class SqlRepo
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WorkRecordSystemDb;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        //user section
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
                    cmd.CommandText = "update Users set PasswordSalt=@Salt, PasswordHash=@Hash, IsAdmin=@Admin where Name=@Name";
                    cmd.Parameters.AddWithValue("Salt", user.PasswordSalt);
                    cmd.Parameters.AddWithValue("Hash", user.PasswordHash);
                    cmd.Parameters.AddWithValue("Admin", user.Role);
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
        public void DeleteUser(string username)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Users where Name=@Name";
                    cmd.Parameters.AddWithValue("Name", username);
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

        //employee section
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Employee";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            var employee = new Employee((int)reader["PersonalNumber"], (string)reader["RoleName"],(string)reader
                                ["FirstName"], (string)reader["LastName"], DateTime.Parse(reader["BirthDate"].ToString()),
                                (string)reader["Email"], (string)reader["Phone"]);
                            employees.Add(employee);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return employees;
        }
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Employee(PersonalNumber, RoleName, FirstName, LastName, BirthDate, Email, Phone) " +
                        "VALUES (@PersonalNumber,@RoleName,@FirstName,@LastName,@BirthDate,@Email,@Phone)";
                    cmd.Parameters.AddWithValue("PersonalNumber", employee.PersonalNumber);
                    cmd.Parameters.AddWithValue("RoleName", employee.RoleName);
                    cmd.Parameters.AddWithValue("FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("BirthDate", employee.BirthDate);
                    cmd.Parameters.AddWithValue("Email", employee.Email);
                    cmd.Parameters.AddWithValue("Phone", employee.PhoneNumber);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        public void DeleteEmployee(int personalNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Employee WHERE PersonalNumber=@PersonalNumber";
                    cmd.Parameters.AddWithValue("PersonalNumber", personalNumber);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        public List<Employee> GetEmployees(string searchString)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Employee WHERE FirstName LIKE @Search";
                    cmd.Parameters.AddWithValue("Search", "%" + searchString + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new Employee((int)reader["PersonalNumber"], (string)reader["RoleName"], (string)reader
                                ["FirstName"], (string)reader["LastName"], DateTime.Parse(reader["BirthDate"].ToString()),
                                (string)reader["Email"], (string)reader["Phone"]);
                            employees.Add(employee);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return employees;
        }
        public void EditEmployee(Employee employee)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Employee SET RoleName=@RoleName, FirstName=@FirstName, LastName=@LastName, BirthDate=@BirthDate, " +
                        "Email=@Email,Phone=@Phone WHERE PersonalNumber=@PersonalNumber";
                    cmd.Parameters.AddWithValue("RoleName", employee.RoleName);
                    cmd.Parameters.AddWithValue("FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("BirthDate", employee.BirthDate);
                    cmd.Parameters.AddWithValue("Email", employee.Email);
                    cmd.Parameters.AddWithValue("Phone", employee.PhoneNumber);
                    cmd.Parameters.AddWithValue("PersonalNumber", employee.PersonalNumber);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        //work section 
        public List<Work> GetWorks()
        {
            List<Work> works = new List<Work>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkType";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var work = new Work((int)reader["WorkTypeId"], reader["Name"].ToString(), reader["Description"].ToString());
                            works.Add(work);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return works;
        }
        public void AddWork(Work work)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO WorkType (WorkTypeId, Name, Description) VALUES (@WorkTypeId,@Name,@Description)";
                    cmd.Parameters.AddWithValue("WorkTypeId", work.WorkId);
                    cmd.Parameters.AddWithValue("Name", work.Name);
                    cmd.Parameters.AddWithValue("Description", work.Description);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void DeleteWork(int workId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM WorkType WHERE WorkTypeId=@WorkId";
                    cmd.Parameters.AddWithValue("WorkId", workId);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void EditWork(Work work)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE WorkType SET Name=@Name, Description=@Description WHERE WorkTypeId=@WorkId";
                    cmd.Parameters.AddWithValue("Name", work.Name);
                    cmd.Parameters.AddWithValue("Description",work.Description);
                    cmd.Parameters.AddWithValue("WorkId", work.WorkId);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
    }
}
