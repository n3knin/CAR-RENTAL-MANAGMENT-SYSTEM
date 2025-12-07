using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;

namespace RentalApp.Data.Repositories
{
    public class CustomerRepository
    {
        // CREATE
        public int Add(Customer customer)
        {
            string sql = @"INSERT INTO Customers 
                          (FirstName, LastName, Email, Phone, Address, DateOfBirth, 
                           DriverLicenseNumber, LicenseIssueDate, LicenseExpiryDate, 
                           LicenseState, EmergencyContact, CustomerType, IsBlacklisted, CreatedAt) 
                          VALUES 
                          (@fn, @ln, @email, @phone, @addr, @dob, @lic, @issue, @exp, 
                           @state, @emergency, @type, @blacklist, @created);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@fn", customer.FirstName);
                    cmd.Parameters.AddWithValue("@ln", customer.LastName);
                    cmd.Parameters.AddWithValue("@email", customer.Email);
                    cmd.Parameters.AddWithValue("@phone", customer.Phone);
                    cmd.Parameters.AddWithValue("@addr", customer.Address);
                    cmd.Parameters.AddWithValue("@dob", customer.DateOfBirth);
                    cmd.Parameters.AddWithValue("@lic", customer.DriverLicenseNumber);
                    cmd.Parameters.AddWithValue("@issue", customer.LicenseIssueDate);
                    cmd.Parameters.AddWithValue("@exp", customer.LicenseExpiryDate);
                    cmd.Parameters.AddWithValue("@state", customer.LicenseState);
                    cmd.Parameters.AddWithValue("@emergency", customer.EmergencyContact);
                    cmd.Parameters.AddWithValue("@type", customer.Type.ToString());
                    cmd.Parameters.AddWithValue("@blacklist", customer.IsBlacklisted);
                    cmd.Parameters.AddWithValue("@created", customer.CreatedAt);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ
        public Customer GetById(int id)
        {
            string sql = "SELECT * FROM Customers WHERE ID = @id";

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
                            return MapReaderToCustomer(reader);
                        }
                    }
                }
            }
            return null;
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            string sql = "SELECT * FROM Customers ORDER BY FirstName, LastName";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(MapReaderToCustomer(reader));
                        }
                    }
                }
            }
            return customers;
        }

        // UPDATE
        public void Update(Customer customer)
        {
            string sql = @"UPDATE Customers SET 
                          FirstName = @fn, LastName = @ln, Email = @email, 
                          Phone = @phone, Address = @addr, IsBlacklisted = @blacklist
                          WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", customer.Id);
                    cmd.Parameters.AddWithValue("@fn", customer.FirstName);
                    cmd.Parameters.AddWithValue("@ln", customer.LastName);
                    cmd.Parameters.AddWithValue("@email", customer.Email);
                    cmd.Parameters.AddWithValue("@phone", customer.Phone);
                    cmd.Parameters.AddWithValue("@addr", customer.Address);
                    cmd.Parameters.AddWithValue("@blacklist", customer.IsBlacklisted);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE
        public void Delete(int id)
        {
            string sql = "DELETE FROM Customers WHERE ID = @id";

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

        // HELPER
        private Customer MapReaderToCustomer(MySqlDataReader reader)
        {
            return new Customer
            {
                Id = reader.GetInt32("ID"),
                FirstName = reader.GetString("FirstName"),
                LastName = reader.GetString("LastName"),
                Email = reader.GetString("Email"),
                Phone = reader.GetString("Phone"),
                Address = reader.GetString("Address"),
                DateOfBirth = reader.GetDateTime("DateOfBirth"),
                DriverLicenseNumber = reader.GetString("DriverLicenseNumber"),
                LicenseIssueDate = reader.IsDBNull(reader.GetOrdinal("LicenseIssueDate")) ? (DateTime?)null : reader.GetDateTime("LicenseIssueDate"),
                LicenseExpiryDate = reader.GetDateTime("LicenseExpiryDate"),
                LicenseState = reader.GetString("LicenseState"),
                EmergencyContact = reader.GetString("EmergencyContact"),
                Type = (CustomerType)Enum.Parse(typeof(CustomerType), reader.GetString("CustomerType")),
                IsBlacklisted = reader.GetBoolean("IsBlacklisted"),
                CreatedAt = reader.GetDateTime("CreatedAt")
            };
        }
    }
}
