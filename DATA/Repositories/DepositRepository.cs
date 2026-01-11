using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;

namespace RentalApp.Data.Repositories
{
    public class DepositRepository
    {
        // CREATE - Add new deposit record
        public int Add(Deposit deposit)
        {
            string sql = @"INSERT INTO Deposits (RentalID, Amount, Status, RefundedAmount, AppliedToInvoice) 
                          VALUES (@rentalId, @amount, @status, @refunded, @applied);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@rentalId", deposit.RentalId);
                    cmd.Parameters.AddWithValue("@amount", deposit.Amount);
                    cmd.Parameters.AddWithValue("@status", deposit.Status.ToString());
                    cmd.Parameters.AddWithValue("@refunded", deposit.RefundedAmount);
                    cmd.Parameters.AddWithValue("@applied", deposit.AppliedToInvoice);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ - Get deposit by ID
        public Deposit GetById(int id)
        {
            string sql = "SELECT * FROM Deposits WHERE ID = @id";

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
                            return MapReaderToDeposit(reader);
                        }
                    }
                }
            }
            return null;
        }

        // READ - Get deposit by Rental ID
        public Deposit GetByRentalId(int rentalId)
        {
            string sql = "SELECT * FROM Deposits WHERE RentalID = @rentalId";

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
                            return MapReaderToDeposit(reader);
                        }
                    }
                }
            }
            return null;
        }

        // UPDATE - Update existing deposit record
        public void Update(Deposit deposit)
        {
            string sql = @"UPDATE Deposits 
                          SET Status = @status, 
                              RefundedAmount = @refunded, 
                              AppliedToInvoice = @applied 
                          WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", deposit.Id);
                    cmd.Parameters.AddWithValue("@status", deposit.Status.ToString());
                    cmd.Parameters.AddWithValue("@refunded", deposit.RefundedAmount);
                    cmd.Parameters.AddWithValue("@applied", deposit.AppliedToInvoice);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // HELPER - Map database reader to Deposit object
        private Deposit MapReaderToDeposit(MySqlDataReader reader)
        {
            return new Deposit
            {
                Id = reader.GetInt32("ID"),
                RentalId = reader.GetInt32("RentalID"),
                Amount = reader.GetDecimal("Amount"),
                Status = (DepositStatus)Enum.Parse(typeof(DepositStatus), reader.GetString("Status")),
                RefundedAmount = reader.GetDecimal("RefundedAmount"),
                AppliedToInvoice = reader.GetBoolean("AppliedToInvoice")
            };
        }
    }
}
