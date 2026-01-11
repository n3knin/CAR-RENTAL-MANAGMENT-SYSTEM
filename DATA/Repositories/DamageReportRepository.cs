using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;
using RentalApp.Data;

namespace RentalApp.DATA.Repositories
{
    public class DamageReportRepository
    {
        public int Add(DamageReport report)
        {
            string sql = @"INSERT INTO damagereports 
                          (InspectionID, DamageType, Location, Severity, Description, EstimatedCost) 
                          VALUES (@InspectionId, @Type, @Location, @Severity, @Description, @Cost);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@InspectionId", report.InspectionId);
                    cmd.Parameters.AddWithValue("@Type", report.Type.ToString());
                    cmd.Parameters.AddWithValue("@Location", report.Location ?? "");
                    cmd.Parameters.AddWithValue("@Severity", report.Severity.ToString());
                    cmd.Parameters.AddWithValue("@Description", report.Description ?? "");
                    cmd.Parameters.AddWithValue("@Cost", report.EstimatedCost);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public DamageReport GetByInspectionId(int inspectionId)
        {
            string sql = "SELECT * FROM damagereports WHERE InspectionID = @InspectionId";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@InspectionId", inspectionId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DamageReport
                            {
                                Id = reader.GetInt32("ID"),
                                InspectionId = reader.GetInt32("InspectionID"),
                                Type = (DamageType)Enum.Parse(typeof(DamageType), reader.GetString("DamageType")),
                                Location = reader.GetString("Location"),
                                Severity = (DamageSeverity)Enum.Parse(typeof(DamageSeverity), reader.GetString("Severity")),
                                Description = reader.GetString("Description"),
                                EstimatedCost = reader.GetDecimal("EstimatedCost")
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
