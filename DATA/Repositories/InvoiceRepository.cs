using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;

namespace RentalApp.Data.Repositories
{
    public class InvoiceRepository
    {
        // CREATE
        public int Add(Invoice invoice)
        {
            string sql = @"INSERT INTO Invoices 
                          (RentalID, IssueDate, RentalCharge, AppliedRateType, 
                           LateFee, DamageFee, FuelCharge, CleaningFee, TotalAmount, IsPaid) 
                          VALUES 
                          (@rentalId, @issue, @rental, @rateType, @late, @damage, @fuel, @clean, @total, @paid);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@rentalId", invoice.RentalId);
                    cmd.Parameters.AddWithValue("@issue", invoice.IssueDate);
                    cmd.Parameters.AddWithValue("@rental", invoice.RentalCharge);
                    cmd.Parameters.AddWithValue("@rateType", invoice.AppliedRateType.HasValue ? invoice.AppliedRateType.Value.ToString() : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@late", invoice.LateFee);
                    cmd.Parameters.AddWithValue("@damage", invoice.DamageFee);
                    cmd.Parameters.AddWithValue("@fuel", invoice.FuelCharge);
                    cmd.Parameters.AddWithValue("@clean", invoice.CleaningFee);
                    cmd.Parameters.AddWithValue("@total", invoice.TotalAmount);
                    cmd.Parameters.AddWithValue("@paid", invoice.IsPaid);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ
        public Invoice GetById(int id)
        {
            string sql = "SELECT * FROM Invoices WHERE ID = @id";

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
                            return MapReaderToInvoice(reader);
                        }
                    }
                }
            }
            return null;
        }

        public Invoice GetByRentalId(int rentalId)
        {
            string sql = "SELECT * FROM Invoices WHERE RentalID = @rentalId";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@rentalId", rentalId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapReaderToInvoice(reader);
                        }
                    }
                }
            }
            return null;
        }

        public List<Invoice> GetUnpaid()
        {
            List<Invoice> invoices = new List<Invoice>();
            string sql = "SELECT * FROM Invoices WHERE IsPaid = FALSE";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            invoices.Add(MapReaderToInvoice(reader));
                        }
                    }
                }
            }
            return invoices;
        }

        // UPDATE
        public void Update(Invoice invoice)
        {
            string sql = @"UPDATE Invoices SET 
                          RentalCharge = @rental, LateFee = @late, DamageFee = @damage,
                          FuelCharge = @fuel, CleaningFee = @clean, TotalAmount = @total, IsPaid = @paid
                          WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", invoice.Id);
                    cmd.Parameters.AddWithValue("@rental", invoice.RentalCharge);
                    cmd.Parameters.AddWithValue("@late", invoice.LateFee);
                    cmd.Parameters.AddWithValue("@damage", invoice.DamageFee);
                    cmd.Parameters.AddWithValue("@fuel", invoice.FuelCharge);
                    cmd.Parameters.AddWithValue("@clean", invoice.CleaningFee);
                    cmd.Parameters.AddWithValue("@total", invoice.TotalAmount);
                    cmd.Parameters.AddWithValue("@paid", invoice.IsPaid);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // HELPER
        private Invoice MapReaderToInvoice(MySqlDataReader reader)
        {
            return new Invoice
            {
                Id = reader.GetInt32("ID"),
                RentalId = reader.GetInt32("RentalID"),
                IssueDate = reader.GetDateTime("IssueDate"),
                RentalCharge = reader.GetDecimal("RentalCharge"),
                AppliedRateType = reader.IsDBNull(reader.GetOrdinal("AppliedRateType")) ? (RateType?)null : (RateType)Enum.Parse(typeof(RateType), reader.GetString("AppliedRateType")),
                LateFee = reader.GetDecimal("LateFee"),
                DamageFee = reader.GetDecimal("DamageFee"),
                FuelCharge = reader.GetDecimal("FuelCharge"),
                CleaningFee = reader.GetDecimal("CleaningFee"),
                TotalAmount = reader.GetDecimal("TotalAmount"),
                IsPaid = reader.GetBoolean("IsPaid")
            };
        }
    }
}
