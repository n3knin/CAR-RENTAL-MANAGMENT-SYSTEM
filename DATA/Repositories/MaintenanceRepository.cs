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
                           (VehicleID, Description, Cost, StartDate, EndDate) 
                           VALUES 
                           (@vehId, @desc, @cost, @start, @end)";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@vehId", record.VehicleId);
                    cmd.Parameters.AddWithValue("@desc", record.Description);
                    cmd.Parameters.AddWithValue("@cost", record.Cost);
                    cmd.Parameters.AddWithValue("@start", record.StartDate);
                    // If EndDate is null (ongoing), save as DBNull
                    cmd.Parameters.AddWithValue("@end", record.EndDate.HasValue ? (object)record.EndDate.Value : DBNull.Value);

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
                                Description = reader.GetString("Description"),
                                Cost = reader.GetDecimal("Cost"),
                                StartDate = reader.GetDateTime("StartDate"),
                                EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? (DateTime?)null : reader.GetDateTime("EndDate")
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
            string sql = "UPDATE MaintenanceRecords SET EndDate = @end WHERE ID = @id";

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
    }
}
