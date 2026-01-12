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
                           WHERE r.Status = 'Completed'
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
        public List<Rental> GetByDateRange(DateTime start, DateTime end)
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
                           WHERE r.ActualPickupDate >= @start AND r.ActualPickupDate <= @end
                           ORDER BY r.ActualPickupDate DESC";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start.Date);
                    cmd.Parameters.AddWithValue("@end", end.Date.AddDays(1).AddSeconds(-1));

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
        public double GetAverageRentalDuration(DateTime start, DateTime end)
        {
            string sql = @"SELECT IFNULL(AVG(DATEDIFF(IFNULL(ActualReturnDate, ExpectedReturnDate), ActualPickupDate)), 0) 
                          FROM Rentals 
                          WHERE ActualPickupDate >= @start AND ActualPickupDate <= @end";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start.Date);
                    cmd.Parameters.AddWithValue("@end", end.Date.AddDays(1).AddSeconds(-1));
                    return Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
        }

        public double GetDamageIncidentRate(DateTime start, DateTime end)
        {
            string sql = @"SELECT 
                (SELECT COUNT(DISTINCT r.ID) FROM Rentals r JOIN VehicleInspections vi ON r.ID = vi.RentalID 
                 WHERE (vi.ExteriorCondition = 'Poor' OR vi.InteriorCondition = 'Poor') 
                 AND r.ActualPickupDate >= @start AND r.ActualPickupDate <= @end) / 
                NULLIF((SELECT COUNT(*) FROM Rentals WHERE ActualPickupDate >= @start AND ActualPickupDate <= @end), 0) * 100";
            
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start.Date);
                    cmd.Parameters.AddWithValue("@end", end.Date.AddDays(1).AddSeconds(-1));
                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDouble(result);
                }
            }
        }

        public int GetTotalRentalDays(DateTime start, DateTime end)
        {
            string sql = @"SELECT IFNULL(SUM(DATEDIFF(IFNULL(ActualReturnDate, ExpectedReturnDate), ActualPickupDate)), 0) 
                          FROM Rentals 
                          WHERE ActualPickupDate >= @start AND ActualPickupDate <= @end";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start.Date);
                    cmd.Parameters.AddWithValue("@end", end.Date.AddDays(1).AddSeconds(-1));
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public int CountTodayPickups()
        {
            string sql = "SELECT COUNT(*) FROM Rentals WHERE DATE(ActualPickupDate) = CURDATE()";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public int CountPendingReturns()
        {
            string sql = "SELECT COUNT(*) FROM Rentals WHERE DATE(ExpectedReturnDate) = CURDATE() AND Status = 'Active'";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int CountActive()
        {
            string sql = "SELECT COUNT(*) FROM Rentals WHERE Status = 'Active'";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int CountCompleted()
        {
            string sql = "SELECT COUNT(*) FROM Rentals WHERE Status = 'Completed'";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int GetActiveRentalCount(int customerId)
        {
            string sql = "SELECT COUNT(*) FROM Rentals WHERE CustomerID = @custId AND Status = 'Active'";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int GetActiveRentalCountByVehicle(int vehicleId)
        {
            string sql = "SELECT COUNT(*) FROM Rentals WHERE VehicleID = @vehId AND Status = 'Active'";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@vehId", vehicleId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
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
                Status = (RentalStatus)Enum.Parse(typeof(RentalStatus), reader.GetString("Status"), true)
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
    