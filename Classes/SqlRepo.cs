using System.Data.SqlClient;
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
                                             );
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
                    cmd.Parameters.AddWithValue("Description", work.Description);
                    cmd.Parameters.AddWithValue("WorkId", work.WorkId);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public List<Work> GetWorks(string searchString)
        {
            List<Work> works = new List<Work>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkType WHERE Name LIKE @Search";
                    cmd.Parameters.AddWithValue("Search", "%" + searchString + "%");
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

        //contract section

        public List<Contract> GetContracts()
        {
            List<Contract> contracts = new List<Contract>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Contract.ContractNumber,Contract.Employee,WorkType.Name, Employee.FirstName, Employee.LastName, Contract.CustomerName, Contract.DateAdded ,Contract.NumberOfHours FROM Contract JOIN Employee ON Contract.Employee = Employee.PersonalNumber JOIN WorkType ON Contract.WorkType = WorkType.WorkTypeId;";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var contract = new Contract((int)reader["ContractNumber"], reader["Name"].ToString(),
                                reader["LastName"].ToString(), reader["CustomerName"].ToString(),
                                DateTime.Parse(reader["DateAdded"].ToString()), (int)reader["NumberOfHours"]);
                            contracts.Add(contract);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return contracts;
        }
        public void AddContract(Contract contract)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                try
                {
                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Contract (WorkType, Employee,CustomerName) VALUES (@WorkId,@EmployeeId,@CustomerName)";
                        cmd.Parameters.AddWithValue("WorkId", contract.WorkId);
                        cmd.Parameters.AddWithValue("EmployeeId", contract.EmployeeId);
                        cmd.Parameters.AddWithValue("CustomerName", contract.CustomerName);
                        cmd.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Špatně zadané údaje. Uživatel nenalezen. \n\nChybová hláška: \n"+ex.Message);
                }
              
            }
        }
        public void DeleteContract(int contractId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Contract WHERE ContractNumber=@ContractId";
                    cmd.Parameters.AddWithValue("ContractId", contractId);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public List<Contract> GetContracts(string searchString)
        {
            List<Contract> contracts = new List<Contract>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Contract.ContractNumber,Contract.Employee,WorkType.Name, Employee.FirstName, Employee.LastName, Contract.CustomerName, Contract.DateAdded ,Contract.NumberOfHours FROM Contract JOIN Employee ON Contract.Employee = Employee.PersonalNumber JOIN WorkType ON Contract.WorkType = WorkType.WorkTypeId WHERE Contract.CustomerName LIKE @Search";
                    cmd.Parameters.AddWithValue("Search", "%" + searchString + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var contract = new Contract((int)reader["ContractNumber"], reader["Name"].ToString(),
                                reader["LastName"].ToString(), reader["CustomerName"].ToString(),
                                DateTime.Parse(reader["DateAdded"].ToString()), (decimal)reader["NumberOfHours"]);
                            contracts.Add(contract);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return contracts;
        }
        //hours section
        public void AddHours(decimal hours, int contractId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Contract SET NumberOfHours=@Hours WHERE ContractNumber=@ContractId;";
                    cmd.Parameters.AddWithValue("@Hours", hours);
                    cmd.Parameters.AddWithValue("@ContractId", contractId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //statistic section
        public int EmployeeCount()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Employee";
                    int rowCount = (int)cmd.ExecuteScalar();
                    sqlConnection.Close();
                    return rowCount;

                }
            }

        }
        public decimal NumberOfHours()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT SUM (NumberOfHours) FROM Contract";
                    decimal rowCount = (decimal)cmd.ExecuteScalar();
                    sqlConnection.Close();
                    return rowCount;

                }
            }
        }
        public int UsersCount()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Users";
                    int rowCount = (int)cmd.ExecuteScalar();
                    sqlConnection.Close();
                    return rowCount;

                }
            }
        }
        public int ContractCount()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Contract";
                    int rowCount = (int)cmd.ExecuteScalar();
                    sqlConnection.Close();
                    return rowCount;

                }
            }
        }
        public int WorkCount()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM WorkType";
                    int rowCount = (int)cmd.ExecuteScalar();
                    sqlConnection.Close();
                    return rowCount;

                }
            }
        }

    }
}
