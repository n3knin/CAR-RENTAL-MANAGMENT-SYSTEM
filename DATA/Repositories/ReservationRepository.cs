using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;

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

        // READ
        public Reservation GetById(int id)
        {
            string sql = "SELECT * FROM Reservations WHERE ID = @id";

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

        public List<Reservation> GetAll()
        {
            List<Reservation> reservations = new List<Reservation>();
            string sql = "SELECT * FROM Reservations ORDER BY StartDate DESC";

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

        public List<Reservation> GetByCustomer(int customerId)
        {
            List<Reservation> reservations = new List<Reservation>();
            string sql = "SELECT * FROM Reservations WHERE CustomerID = @custId";

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

        // UPDATE
        public void Update(Reservation reservation)
        {
            string sql = @"UPDATE Reservations SET 
                          Status = @status, StartDate = @start, EndDate = @end
                          WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", reservation.Id);
                    cmd.Parameters.AddWithValue("@status", reservation.Status.ToString());
                    cmd.Parameters.AddWithValue("@start", reservation.StartDate);
                    cmd.Parameters.AddWithValue("@end", reservation.EndDate);

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

        // HELPER
        private Reservation MapReaderToReservation(MySqlDataReader reader)
        {
            return new Reservation
            {
                Id = reader.GetInt32("ID"),
                CustomerId = reader.GetInt32("CustomerID"),
                VehicleId = reader.GetInt32("VehicleID"),
                StartDate = reader.GetDateTime("StartDate"),
                EndDate = reader.GetDateTime("EndDate"),
                Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), reader.GetString("Status")),
                CreatedAt = reader.GetDateTime("CreatedAt")
            };
        }
    }
}
