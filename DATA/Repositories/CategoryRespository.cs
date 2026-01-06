using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;

namespace RentalApp.Data.Repositories
{
    public class CategoryRepository
    {
        public List<VehicleCategory> GetAll()
        {
            List<VehicleCategory> categories = new List<VehicleCategory>();
            string sql = "SELECT * FROM vehiclecategories";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(MapReaderToCategory(reader));
                        }
                    }
                }
            }

            return categories;
        }

        public VehicleCategory GetById(int id)
        {
            string sql = "SELECT * FROM vehiclecategories WHERE ID = @id";

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
                            return MapReaderToCategory(reader);
                        }
                    }
                }
            }

            return null;
        }

        public void Add(VehicleCategory category)
        {
            string sql = @"INSERT INTO vehiclecategories (CategoryName, HourlyRate, DailyRate, WeeklyRate, MonthlyRate, Description) 
                          VALUES (@name, @hourly, @daily, @weekly, @monthly, @desc)";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", category.CategoryName);
                    cmd.Parameters.AddWithValue("@hourly", category.HourlyRate);
                    cmd.Parameters.AddWithValue("@daily", category.DailyRate);
                    cmd.Parameters.AddWithValue("@weekly", category.WeeklyRate);
                    cmd.Parameters.AddWithValue("@monthly", category.MonthlyRate);
                    cmd.Parameters.AddWithValue("@desc", category.Description ?? "");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRate(int categoryId, decimal dailyRate, decimal weeklyRate, decimal monthlyRate)
        {
            string sql = @"UPDATE vehiclecategories 
                          SET DailyRate = @daily, 
                              WeeklyRate = @weekly,
                              MonthlyRate = @monthly
                          WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", categoryId);
                    cmd.Parameters.AddWithValue("@daily", dailyRate);
                    cmd.Parameters.AddWithValue("@weekly", weeklyRate);
                    cmd.Parameters.AddWithValue("@monthly", monthlyRate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private VehicleCategory MapReaderToCategory(MySqlDataReader reader)
        {
            return new VehicleCategory
            {
                Id = reader.GetInt32("ID"),
                CategoryName = reader.GetString("CategoryName"),
                HourlyRate = reader.GetDecimal("HourlyRate"),
                DailyRate = reader.GetDecimal("DailyRate"),
                WeeklyRate = reader.GetDecimal("WeeklyRate"),
                MonthlyRate = reader.GetDecimal("MonthlyRate"),
                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? "" : reader.GetString("Description")
            };
        }
    }
}
