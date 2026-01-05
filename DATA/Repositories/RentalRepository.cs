using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;

namespace RentalApp.Data.Repositories
{
    public class RentalRepository
    {
        // CREATE
        public int Add(Rental rental)
        {
            string sql = @"INSERT INTO Rentals 
                          (ReservationID, CustomerID, VehicleID, RentalAgentID, 
                           ActualPickupDate, ExpectedReturnDate, ActualReturnDate, 
                           StartMileage, EndMileage, Status) 
                          VALUES 
                          (@resId, @custId, @vehId, @agentId, @pickup, @expectedReturn, @return, @startMile, @endMile, @status);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@resId", rental.ReservationId.HasValue ? (object)rental.ReservationId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@custId", rental.CustomerId);
                    cmd.Parameters.AddWithValue("@vehId", rental.VehicleId);
                    cmd.Parameters.AddWithValue("@agentId", rental.RentalAgentId);
                    cmd.Parameters.AddWithValue("@pickup", rental.ActualPickupDate);
                    cmd.Parameters.AddWithValue("@expectedReturn", rental.ExpectedReturnDate);
                    cmd.Parameters.AddWithValue("@return", rental.ActualReturnDate.HasValue ? (object)rental.ActualReturnDate.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@startMile", rental.StartMileage);
                    cmd.Parameters.AddWithValue("@endMile", rental.EndMileage.HasValue ? (object)rental.EndMileage.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", rental.Status.ToString());

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ
        public Rental GetById(int id)
        {
            string sql = "SELECT * FROM Rentals WHERE ID = @id";

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
                            return MapReaderToRental(reader);
                        }
                    }
                }
            }
            return null;
        }

        public List<Rental> GetAll()
        {
            List<Rental> rentals = new List<Rental>();
            string sql = @"SELECT r.*, 
                                  c.FirstName, c.LastName, 
                                  v.Make, v.Model, v.Year,
                                  r.RentalAgentId,
                                  ra.Firstname as RentalAgentFirstName,
                                  ra.Lastname as RentalAgentLastName,
                                  ra.Role as RentalAgentRole
                           FROM Rentals r
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           LEFT JOIN Users ra ON r.RentalAgentId = ra.ID
                           ORDER BY r.ActualPickupDate DESC";


            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentals.Add(MapReaderToRental(reader));
                        }
                    }
                }
            }
            return rentals;
        }

        public List<Rental> GetActiveRentals()
        {
            List<Rental> rentals = new List<Rental>();
            string sql = @"SELECT r.*, 
                                  c.FirstName, c.LastName, 
                                  v.Make, v.Model, v.Year,
                                  r.RentalAgentId,
                                  ra.Firstname as RentalAgentFirstName,
                                  ra.Lastname as RentalAgentLastName,
                                  ra.Role as RentalAgentRole
                           FROM Rentals r
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           LEFT JOIN Users ra ON r.RentalAgentId = ra.ID
                           WHERE r.Status = 'Active'
                           ORDER BY r.ActualPickupDate DESC";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentals.Add(MapReaderToRental(reader));
                        }
                    }
                }
            }
            return rentals;
        }

        // UPDATE
        public void Update(Rental rental)
        {
            string sql = @"UPDATE Rentals SET 
                          ActualReturnDate = @return, EndMileage = @endMile, Status = @status
                          WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", rental.Id);
                    cmd.Parameters.AddWithValue("@return", rental.ActualReturnDate.HasValue ? (object)rental.ActualReturnDate.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@endMile", rental.EndMileage.HasValue ? (object)rental.EndMileage.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", rental.Status.ToString());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE
        public void Delete(int id)
        {
            string sql = "DELETE FROM Rentals WHERE ID = @id";

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
        private Rental MapReaderToRental(MySqlDataReader reader)
        {
            var rental = new Rental
            {
                Id = reader.GetInt32("ID"),
                ReservationId = reader.IsDBNull(reader.GetOrdinal("ReservationID")) ? (int?)null : reader.GetInt32("ReservationID"),
                CustomerId = reader.GetInt32("CustomerID"),
                VehicleId = reader.GetInt32("VehicleID"),
                RentalAgentId = reader.GetInt32("RentalAgentID"),
                ActualPickupDate = reader.GetDateTime("ActualPickupDate"),
                ExpectedReturnDate = reader.IsDBNull(reader.GetOrdinal("ExpectedReturnDate")) ? (DateTime?)null : reader.GetDateTime("ExpectedReturnDate"),
                ActualReturnDate = reader.IsDBNull(reader.GetOrdinal("ActualReturnDate")) ? (DateTime?)null : reader.GetDateTime("ActualReturnDate"),
                StartMileage = reader.GetInt32("StartMileage"),
                EndMileage = reader.IsDBNull(reader.GetOrdinal("EndMileage")) ? (int?)null : reader.GetInt32("EndMileage"),
                Status = (RentalStatus)Enum.Parse(typeof(RentalStatus), reader.GetString("Status"))
            };

            // Populate Customer if available from JOIN
            try
            {
                if (!reader.IsDBNull(reader.GetOrdinal("FirstName")))
                {
                    rental.Customer = new Customer
                    {
                        Id = rental.CustomerId,
                        FirstName = reader.GetString("FirstName"),
                        LastName = reader.GetString("LastName")
                    };
                }
            }
            catch { /* Columns not found, ignore */ }

            // Populate Vehicle if available from JOIN
            try
            {
                if (!reader.IsDBNull(reader.GetOrdinal("Make")))
                {
                    rental.Vehicle = new RentalApp.Models.Vehicles.Sedan
                    {
                        VehicleId = rental.VehicleId,
                        Make = reader.GetString("Make"),
                        Model = reader.GetString("Model"),
                        Year = reader.GetInt32("Year")
                    };
                }
            }
            catch { /* Columns not found, ignore */ }

            // Populate RentalAgent if available from JOIN
            try
            {
                if (!reader.IsDBNull(reader.GetOrdinal("RentalAgentFirstName")))
                {
                    string role = reader.GetString("RentalAgentRole");
                    
                    // Create appropriate user type based on role
                    if (role == "Admin")
                    {
                        rental.RentalAgent = new RentalApp.Models.Users.Admin
                        {
                            Id = rental.RentalAgentId,
                            Firstname = reader.GetString("RentalAgentFirstName"),
                            Lastname = reader.GetString("RentalAgentLastName")
                        };
                    }
                    else // RentalAgent
                    {
                        rental.RentalAgent = new RentalApp.Models.Users.RentalAgent
                        {
                            Id = rental.RentalAgentId,
                            Firstname = reader.GetString("RentalAgentFirstName"),
                            Lastname = reader.GetString("RentalAgentLastName")
                        };
                    }
                }
            }
            catch { /* Columns not found, ignore */ }

            return rental;
        }
    }
}
    