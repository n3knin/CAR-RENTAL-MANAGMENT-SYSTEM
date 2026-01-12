using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Users;

namespace RentalApp.Data.Repositories
{
    public class UserRepository
    {
        // CREATE - Add new user to database
        public int Add(User user)
        {
            string sql = @"INSERT INTO Users (Firstname, Lastname, Username, Password, Role, Status) 
                          VALUES (@firstname, @lastname, @username, @password, @role, @status);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@firstname", user.Firstname);
                    cmd.Parameters.AddWithValue("@lastname", user.Lastname);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.GetPasswordHash());
                    cmd.Parameters.AddWithValue("@role", user.GetRoleName());
                    cmd.Parameters.AddWithValue("@status", user.Status);

                    // Return the new user ID
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ - Get user by ID
        public User GetById(int id)
        {
            string sql = "SELECT * FROM Users WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapReaderToUser(reader);
                        }
                    }
                }
            }

            return null; // User not found
        }

        // READ - Get user by username (for login)
        public User GetByUsername(string username)
        {
            string sql = "SELECT * FROM Users WHERE Username = @username";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapReaderToUser(reader);
                        }
                    }
                }
            }

            return null; // User not found
        }


        // READ - Get all users
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            string sql = "SELECT * FROM Users WHERE Status = 'Active' ORDER BY Firstname, Lastname";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(MapReaderToUser(reader));
                        }
                    }
                }
            }

            return users;
        }

        // READ - Get users by role
        public List<User> GetByRole(string role)
        {
            List<User> users = new List<User>();
            string sql = "SELECT * FROM Users WHERE Role = @role";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@role", role);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(MapReaderToUser(reader));
                        }
                    }
                }
            }

            return users;
        }

        // UPDATE - Update existing user
        public void Update(User user)
        {
            string sql = @"UPDATE Users 
                          SET Firstname = @firstname, 
                              Lastname = @lastname, 
                              Username = @username, 
                              Password = @password,
                              Role = @role
                          WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", user.Id);
                    cmd.Parameters.AddWithValue("@firstname", user.Firstname);
                    cmd.Parameters.AddWithValue("@lastname", user.Lastname);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.GetPasswordHash());
                    cmd.Parameters.AddWithValue("@role", user.GetRoleName());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE - Delete user by ID (Soft Delete)
        public void Delete(int id)
        {
            string sql = "UPDATE Users SET Status = 'Inactive' WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // HELPER - Check if username already exists
        public bool UsernameExists(string username)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @username";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // HELPER - Map database reader to User object
        private User MapReaderToUser(MySqlDataReader reader)
        {
            int id = reader.GetInt32("ID");
            string firstname = reader.GetString("Firstname");
            string lastname = reader.GetString("Lastname");
            string username = reader.GetString("Username");
            string password = reader.GetString("Password");
            string role = reader.GetString("Role");
            string status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "Active" : reader.GetString("Status");

            // Create the appropriate user type based on role
            User user;
            if (role == "Admin")
            {
                user = new Admin(id, firstname, lastname, username);
            }
            else if (role == "RentalAgent")
            {
                user = new RentalAgent(id, firstname, lastname, username);
            }
            else if (role == "Manager")
            {
                user = new Manager(id, firstname, lastname, username);
            }
            else
            {
                throw new Exception($"Unknown role: {role}");
            }

            // Set password hash directly (don't hash again - it's already hashed in DB)
            user.SetPasswordHash(password);
            user.Status = status;

            return user;
        }
    }
}
