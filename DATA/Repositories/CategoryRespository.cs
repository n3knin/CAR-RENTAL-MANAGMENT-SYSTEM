using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Vehicles;
using RentalApp.Models.Core;


namespace RentalApp.Data.Repositories
{
    public class CategoryRespository
    {
      public List<VehicleCategory> GetAll()
      {
        List<VehicleCategory> categories = new List<VehicleCategory>();
        string sql = "SELECT * FROM VehicleCategory";

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
        string sql = "SELECT * FROM VehicleCategory WHERE ID = @id";

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

        return null; // Category not found
      }

      public void Add(VehicleCategory category)
      {
        string sql = @"INSERT INTO VehicleCategory (CategoryName, DailyRate) 
                      VALUES (@categoryName, @dailyRate);";

        using (var conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@categoryName", category.CategoryName);
                cmd.Parameters.AddWithValue("@dailyRate", category.DailyRate);

                cmd.ExecuteNonQuery();
            }
        }
      }

      public void UpdateRate(int categoryId, decimal dailyRate, decimal weeklyRate, decimal monthlyRate)
      {
        string sql = @"UPDATE VehicleCategory 
                      SET DailyRate = @dailyRate, 
                          WeeklyRate = @weeklyRate,
                          MonthlyRate = @monthlyRate
                      WHERE ID = @id;";

        using (var conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", categoryId);
                cmd.Parameters.AddWithValue("@dailyRate", dailyRate);
                cmd.Parameters.AddWithValue("@weeklyRate", weeklyRate);
                cmd.Parameters.AddWithValue("@monthlyRate", monthlyRate);

                cmd.ExecuteNonQuery();
            }
        }
      }
      private VehicleCategory MapReaderToCategory(MySqlDataReader reader)
        {
            return new VehicleCategory
            {
                Id = reader.GetInt32("ID"), // Check your exact column name in DB
                CategoryName = reader.GetString("CategoryName"),
                DailyRate = reader.GetDecimal("DailyRate"),
                WeeklyRate = reader.GetDecimal("WeeklyRate"),
                MonthlyRate = reader.GetDecimal("MonthlyRate")
            };
        }
    }
}