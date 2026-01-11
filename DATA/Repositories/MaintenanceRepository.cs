using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;

namespace RentalApp.Data.Repositories
{
    public class MaintenanceRepository
    {
        // 1. Add a new maintenance record
        public void Add(MaintenanceRecord record)
        {
            // Simple SQL to insert data
            string sql = @"INSERT INTO MaintenanceRecords 
                           (VehicleID, MaintenanceType, Cost, StartDate, EndDate, IsCompleted) 
                           VALUES 
                           (@vehId, @type, @cost, @start, @end, @completed)";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@vehId", record.VehicleId);
                    cmd.Parameters.AddWithValue("@type", record.Type.ToString());
                    cmd.Parameters.AddWithValue("@cost", record.Cost);
                    cmd.Parameters.AddWithValue("@start", record.StartDate);
                    // If EndDate is null (ongoing), save as DBNull
                    cmd.Parameters.AddWithValue("@end", record.EndDate.HasValue ? (object)record.EndDate.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@completed", record.IsCompleted);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2. Get all maintenance records for a specific car
        public List<MaintenanceRecord> GetByVehicleId(int vehicleId)
        {
            List<MaintenanceRecord> list = new List<MaintenanceRecord>();
            string sql = "SELECT * FROM MaintenanceRecords WHERE VehicleID = @vehId";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@vehId", vehicleId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var record = new MaintenanceRecord
                            {
                                Id = reader.GetInt32("ID"),
                                VehicleId = reader.GetInt32("VehicleID"),
                                Type = (MaintenanceRecord.MaintenanceType)Enum.Parse(typeof(MaintenanceRecord.MaintenanceType), reader.GetString("MaintenanceType")),
                                Cost = reader.GetDecimal("Cost"),
                                StartDate = reader.GetDateTime("StartDate"),
                                EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? (DateTime?)null : reader.GetDateTime("EndDate"),
                                IsCompleted = reader.GetBoolean("IsCompleted")
                            };
                            list.Add(record);
                        }
                    }
                }
            }
            return list;
        }

        // 3. Mark a maintenance job as finished
        public void CompleteMaintenance(int id, DateTime endDate)
        {
            string sql = "UPDATE MaintenanceRecords SET EndDate = @end, IsCompleted = 1 WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@end", endDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int CountMaintenanceRecords(int vehicleId)
        {
            string sql = "SELECT COUNT(*) FROM MaintenanceRecords WHERE VehicleID = @vehId";

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
    }
}
