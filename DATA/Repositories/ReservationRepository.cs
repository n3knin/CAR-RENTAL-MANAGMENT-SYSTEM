using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;
using RentalApp.Models.Vehicles; // Needed for 'Sedan' placeholder

namespace RentalApp.Data.Repositories
{
    public class ReservationRepository
    {
        // CREATE
        public int Add(Reservation reservation)
        {
            string sql = @"INSERT INTO Reservations 
                          (CustomerID, VehicleID, StartDate, EndDate, Status, CreatedAt) 
                          VALUES (@custId, @vehId, @start, @end, @status, @created);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@custId", reservation.CustomerId);
                    cmd.Parameters.AddWithValue("@vehId", reservation.VehicleId);
                    cmd.Parameters.AddWithValue("@start", reservation.StartDate);
                    cmd.Parameters.AddWithValue("@end", reservation.EndDate);
                    cmd.Parameters.AddWithValue("@status", reservation.Status.ToString());
                    cmd.Parameters.AddWithValue("@created", reservation.CreatedAt);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ - Get Count of Active Reservations for a Customer
        public int GetActiveReservationCount(int customerId)
        {
            string sql = @"SELECT COUNT(*) FROM Reservations 
                           WHERE CustomerID = @custId 
                           AND (Status = 'Pending' OR Status = 'Confirmed')";

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

        // READ - Get All with Details (Customer Name + Vehicle Make/Model)
        public List<Reservation> GetAll()
        {
            List<Reservation> reservations = new List<Reservation>();
            
            // JOIN query to get related names
            string sql = @"SELECT r.*, 
                                  c.FirstName, c.LastName, 
                                  v.Make, v.Model, v.Year 
                           FROM Reservations r
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           WHERE r.Status = 'Pending'
                           ORDER BY r.StartDate DESC";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(MapReaderToReservation(reader));
                        }
                    }
                }
            }
            return reservations;
        }
        public List<Reservation> GetConfirmed()
        {
            List<Reservation> reservations = new List<Reservation>();
            
            // JOIN query to get related names
            string sql = @"SELECT r.*, 
                                  c.FirstName, c.LastName, 
                                  v.Make, v.Model, v.Year 
                           FROM Reservations r
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           ORDER BY r.CreatedAt DESC";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(MapReaderToReservation(reader));
                        }
                    }
                }
            }
            return reservations;
        }

        // READ - Get By Customer with Details
        public List<Reservation> GetByCustomer(int customerId)
        {
            List<Reservation> reservations = new List<Reservation>();
            string sql = @"SELECT r.*, 
                                  c.FirstName, c.LastName, 
                                  v.Make, v.Model, v.Year 
                           FROM Reservations r
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           WHERE r.CustomerID = @custId";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@custId", customerId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(MapReaderToReservation(reader));
                        }
                    }
                }
            }
            return reservations;
        }

        public Reservation GetById(int id)
        {
            string sql = @"SELECT r.*, 
                                  c.FirstName, c.LastName, 
                                  v.Make, v.Model, v.Year 
                           FROM Reservations r
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           WHERE r.ID = @id";

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
                            return MapReaderToReservation(reader);
                        }
                    }
                }
            }
            return null;
        }

        // UPDATE
        public void Update(Reservation reservation)
        {
            string sql = @"UPDATE Reservations SET 
                           CustomerID = @customerId,
                           VehicleID = @vehicleId,
                           StartDate = @start, 
                           EndDate = @end,
                           Status = @status
                           WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", reservation.Id);
                    cmd.Parameters.AddWithValue("@customerId", reservation.CustomerId);
                    cmd.Parameters.AddWithValue("@vehicleId", reservation.VehicleId);
                    cmd.Parameters.AddWithValue("@start", reservation.StartDate);
                    cmd.Parameters.AddWithValue("@end", reservation.EndDate);
                    cmd.Parameters.AddWithValue("@status", reservation.Status.ToString());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // UPDATE STATUS ONLY
        public void UpdateStatus(int reservationId, ReservationStatus status)
        {
            string sql = "UPDATE Reservations SET Status = @status WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    cmd.Parameters.AddWithValue("@status", status.ToString());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE
        public void Delete(int id)
        {
            string sql = "DELETE FROM Reservations WHERE ID = @id";

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
        public int CountPending()
        {
            string sql = "SELECT COUNT(*) FROM Reservations WHERE Status = 'Pending';";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return 0;
        }
        public int CountConfirmed()
        {
            string sql = "SELECT COUNT(*) FROM Reservations WHERE Status = 'Confirmed';";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return 0;
        }

        // HELPER
        private Reservation MapReaderToReservation(MySqlDataReader reader)
        {
            var reservation = new Reservation
            {
                Id = reader.GetInt32("ID"),
                CustomerId = reader.GetInt32("CustomerID"),
                VehicleId = reader.GetInt32("VehicleID"),
                StartDate = reader.GetDateTime("StartDate"),
                EndDate = reader.GetDateTime("EndDate"),
                Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), reader.GetString("Status")),
                CreatedAt = reader.GetDateTime("CreatedAt")
            };

            // Attempt to populate Customer details if the columns exist (from JOIN)
            try
            {
                if (!reader.IsDBNull(reader.GetOrdinal("FirstName")))
                {
                    reservation.Customer = new Customer
                    {
                        Id = reservation.CustomerId,
                        FirstName = reader.GetString("FirstName"),
                        LastName = reader.GetString("LastName")
                    };
                }
            }
            catch { /* Columns not found, ignore */ }

            // Attempt to populate Vehicle details if the columns exist (from JOIN)
            try
            {
                if (!reader.IsDBNull(reader.GetOrdinal("Make")))
                {
                    // Using 'Sedan' as a concrete container for display purpose
                    reservation.Vehicle = new Sedan
                    {
                        VehicleId = reservation.VehicleId,
                        Make = reader.GetString("Make"),
                        Model = reader.GetString("Model"),
                        Year = reader.GetInt32("Year")
                    };
                }
            }
            catch { /* Columns not found, ignore */ }

            return reservation;
        }
    }
}

