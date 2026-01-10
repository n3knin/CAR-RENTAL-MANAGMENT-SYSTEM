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
            string sql = @"SELECT i.*, 
                                  CONCAT(c.FirstName, ' ', c.LastName) as CustomerName,
                                  CONCAT(v.Make, ' ', v.Model, ' (', v.Year, ')') as VehicleInfo,
                                  CONCAT(u.Firstname, ' ', u.Lastname) as AgentName
                           FROM Invoices i
                           LEFT JOIN Rentals r ON i.RentalID = r.ID
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           LEFT JOIN Users u ON r.RentalAgentId = u.ID
                           WHERE i.IsPaid = FALSE";

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
        public List<Invoice> GetAllPaid()
        {
            List<Invoice> invoices = new List<Invoice>();
            string sql = @"SELECT i.*, 
                                  CONCAT(c.FirstName, ' ', c.LastName) as CustomerName,
                                  CONCAT(v.Make, ' ', v.Model, ' (', v.Year, ')') as VehicleInfo,
                                  CONCAT(u.Firstname, ' ', u.Lastname) as AgentName
                           FROM Invoices i
                           LEFT JOIN Rentals r ON i.RentalID = r.ID
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           LEFT JOIN Users u ON r.RentalAgentId = u.ID
                           WHERE i.IsPaid = TRUE";

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
        public int CountToday()
        {
            string sql = "SELECT COUNT(*) FROM Invoices WHERE DATE(IssueDate) = CURDATE()";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public decimal SumInvoicedToday()
        {
            string sql = "SELECT IFNULL(SUM(TotalAmount), 0) FROM Invoices WHERE DATE(IssueDate) = CURDATE() AND IsPaid = TRUE";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }
        public decimal SumRevenue()
        {
            string sql = "SELECT IFNULL(SUM(TotalAmount), 0) FROM Invoices WHERE IsPaid = TRUE";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }
        public Dictionary<int, decimal> GetWeeklyRevenue()
        {   
            DateTime today = DateTime.Today;
            int diff = (int)today.DayOfWeek; 
            DateTime startOfWeek = today.AddDays(-diff).Date; 
            DateTime endOfWeek = startOfWeek.AddDays(6).AddHours(23).AddMinutes(59); 
            var results = new Dictionary<int, decimal>();
            for (int i = 0; i < 7; i++) results[i] = 0;
            string sql = @"SELECT DAYOFWEEK(IssueDate) - 1 AS DayIndex, SUM(TotalAmount) AS Total 
                        FROM Invoices 
                        WHERE IssueDate >= @start AND IssueDate <= @end AND IsPaid = TRUE
                        GROUP BY DayIndex";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", startOfWeek);
                    cmd.Parameters.AddWithValue("@end", endOfWeek);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int day = reader.GetInt32("DayIndex");
                            decimal total = reader.GetDecimal("Total");
                            results[day] = total;
                        }
                    }
                }
            }
            return results;
        }

        public List<ReportRow> GetReportData(DateTime start, DateTime end)
        {
            List<ReportRow> reports = new List<ReportRow>();
            string sql = @"SELECT i.IssueDate, 
                                  CONCAT(v.Make, ' ', v.Model) as VehicleInfo, 
                                  CONCAT(c.FirstName, ' ', c.LastName) as CustomerName,
                                  DATEDIFF(IFNULL(r.ActualReturnDate, r.ExpectedReturnDate), r.ActualPickupDate) as Duration,
                                  i.TotalAmount
                           FROM Invoices i
                           JOIN Rentals r ON i.RentalID = r.ID
                           JOIN Vehicles v ON r.VehicleID = v.ID
                           JOIN Customers c ON r.CustomerID = c.ID
                           WHERE i.IssueDate >= @start AND i.IssueDate <= @end
                           ORDER BY i.IssueDate DESC";

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
                            reports.Add(new ReportRow
                            {
                                IssueDate = reader.GetDateTime("IssueDate"),
                                VehicleInfo = reader.GetString("VehicleInfo"),
                                CustomerName = reader.GetString("CustomerName"),
                                DurationDays = reader.GetInt32("Duration"),
                                TotalAmount = reader.GetDecimal("TotalAmount")
                            });
                        }
                    }
                }
            }
            return reports;
        }

        public Dictionary<string, decimal> GetMonthlyRevenue(int count = 6)
        {
            var results = new Dictionary<string, decimal>();
            string sql = @"SELECT DATE_FORMAT(IssueDate, '%b %Y') as Month, SUM(TotalAmount) as Total 
                           FROM Invoices 
                           WHERE IsPaid = TRUE 
                           GROUP BY DATE_FORMAT(IssueDate, '%Y-%m')
                           ORDER BY MAX(IssueDate) DESC
                           LIMIT @limit";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@limit", count);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader.GetString("Month"), reader.GetDecimal("Total"));
                        }
                    }
                }
            }
            return results;
        }

        public Dictionary<string, int> GetCategoryUsageCurrentMonth()
        {
            var results = new Dictionary<string, int>();
            string sql = @"SELECT vc.CategoryName, COUNT(*) as UsageCount
                           FROM Invoices i
                           JOIN Rentals r ON i.RentalID = r.ID
                           JOIN Vehicles v ON r.VehicleID = v.ID
                           JOIN VehicleCategories vc ON v.CategoryID = vc.ID
                           WHERE MONTH(i.IssueDate) = MONTH(CURRENT_DATE())
                             AND YEAR(i.IssueDate) = YEAR(CURRENT_DATE())
                           GROUP BY vc.CategoryName";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader.GetString("CategoryName"), reader.GetInt32("UsageCount"));
                        }
                    }
                }
            }
            return results;
        }

        // HELPER
        private Invoice MapReaderToInvoice(MySqlDataReader reader)
        {
            var invoice = new Invoice
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

            // Map Extra Fields from JOINs if they exist
            try
            {
                if (!reader.IsDBNull(reader.GetOrdinal("CustomerName")))
                    invoice.CustomerName = reader.GetString("CustomerName");
                
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleInfo")))
                    invoice.VehicleInfo = reader.GetString("VehicleInfo");
                
                if (!reader.IsDBNull(reader.GetOrdinal("AgentName")))
                    invoice.RentalAgentName = reader.GetString("AgentName");
            }
            catch { /* Columns not in result set */ }

            return invoice;
        }
        
    }

    public class ReportRow
    {
        public DateTime IssueDate { get; set; }
        public string VehicleInfo { get; set; }
        public string CustomerName { get; set; }
        public int DurationDays { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
