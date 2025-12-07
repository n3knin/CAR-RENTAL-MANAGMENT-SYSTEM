using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;

namespace RentalApp.Data.Repositories
{
    public class PaymentRepository
    {
        // CREATE
        public int Add(Payment payment)
        {
            string sql = @"INSERT INTO Payments 
                          (InvoiceID, Amount, PaymentDate, PaymentMethod) 
                          VALUES (@invoiceId, @amount, @date, @method);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceId", payment.InvoiceId);
                    cmd.Parameters.AddWithValue("@amount", payment.Amount);
                    cmd.Parameters.AddWithValue("@date", payment.PaymentDate);
                    cmd.Parameters.AddWithValue("@method", payment.Method.ToString());

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ
        public List<Payment> GetByInvoice(int invoiceId)
        {
            List<Payment> payments = new List<Payment>();
            string sql = "SELECT * FROM Payments WHERE InvoiceID = @invoiceId";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceId", invoiceId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            payments.Add(MapReaderToPayment(reader));
                        }
                    }
                }
            }
            return payments;
        }

        // HELPER
        private Payment MapReaderToPayment(MySqlDataReader reader)
        {
            return new Payment
            {
                Id = reader.GetInt32("ID"),
                InvoiceId = reader.GetInt32("InvoiceID"),
                Amount = reader.GetDecimal("Amount"),
                PaymentDate = reader.GetDateTime("PaymentDate"),
                Method = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), reader.GetString("PaymentMethod"))
            };
        }
    }
}
