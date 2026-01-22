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
        public int CountBlacklisted()
        {
            string sql = "SELECT COUNT(*) FROM Customers WHERE IsBlacklisted = 1";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public int CountNewCustomers()
        {
            string sql = "SELECT COUNT(*) FROM Customers WHERE CreatedAt >= DATE_SUB(CURRENT_DATE(), INTERVAL 7 DAY);";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            
            // JOIN query to see if there is an ACTIVE reservation (Pending or Confirmed)
            // We group by Customer.ID to ensure we don't get duplicates if data is messy,
            // though logically a customer should only have one active rental at a time.
            string sql = @"SELECT c.*, 
                                  r.ID as ReservationID, 
                                  v.Make, v.Model 
                           FROM Customers c
                           LEFT JOIN Reservations r ON c.ID = r.CustomerID 
                                     AND (r.Status = 'Pending' OR r.Status = 'Confirmed')
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           ORDER BY c.FirstName, c.LastName";

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

        public List<Customer> GetAvailableCustomers()
        {
            List<Customer> customers = new List<Customer>();

            string sql = @"
                SELECT * FROM Customers c
                WHERE (c.IsBlacklisted = 0 OR c.IsBlacklisted IS NULL)
                AND NOT EXISTS (
                    SELECT 1 FROM Rentals r 
                    WHERE r.CustomerID = c.ID 
                    AND r.Status IN ('Active', 'Overdue')
                )
                AND NOT EXISTS (
                    SELECT 1 FROM Reservations res 
                    WHERE res.CustomerID = c.ID 
                    AND res.Status IN ('Pending', 'Confirmed')
                )
                ORDER BY FirstName, LastName";

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

        // BLACKLIST
        public void BlacklistCustomer(int id)
        {
            string sql = "UPDATE Customers SET IsBlacklisted = 1 WHERE ID = @id";

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

        public double GetRetentionRate()
        {
            string sqlRepeat = "SELECT COUNT(*) FROM (SELECT CustomerID FROM Rentals GROUP BY CustomerID HAVING COUNT(*) > 1) as RepeatCust";
            string sqlTotal = "SELECT COUNT(DISTINCT CustomerID) FROM Rentals";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                int repeat = 0;
                int total = 0;

                using (var cmd = new MySqlCommand(sqlRepeat, conn))
                {
                    repeat = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var cmd = new MySqlCommand(sqlTotal, conn))
                {
                    total = Convert.ToInt32(cmd.ExecuteScalar());
                }

                if (total == 0) return 0;
                return (double)repeat / total * 100;
            }
        }
        public bool RecordExistedbyEmail(string email)
        {
            string sql = "SELECT COUNT(*) FROM Customers WHERE Email = @email";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        public bool RecordExistedbyDriverLicenseNumber(string driverLicenseNumber)
        {
            string sql = "SELECT COUNT(*) FROM Customers WHERE DriverLicenseNumber = @driverLicenseNumber";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@driverLicenseNumber", driverLicenseNumber);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        public bool RecordExistedbyPhone(string phone)
        {
            string sql = "SELECT COUNT(*) FROM Customers WHERE Phone = @phone";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public bool RecordExistedbyName(string firstName, string lastName)
        {
            string sql = "SELECT COUNT(*) FROM Customers WHERE FirstName = @firstName AND LastName = @lastName";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        // HELPER
        private Customer MapReaderToCustomer(MySqlDataReader reader)
        {
            var customer = new Customer
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

            // Populate active rental info if found (from the JOIN)
            try
            {
                if (!reader.IsDBNull(reader.GetOrdinal("ReservationID")))
                {
                    customer.ActiveReservationId = reader.GetInt32("ReservationID");
                    
                    if (!reader.IsDBNull(reader.GetOrdinal("Make")))
                    {
                        customer.CurrentVehicleInfo = $"{reader.GetString("Make")} {reader.GetString("Model")}";
                    }
                }
            }
            catch { /* Ignore if columns not found */ }

            

            return customer;
        }
    }
}
