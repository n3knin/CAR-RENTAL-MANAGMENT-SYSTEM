using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;
using RentalApp.Data;

namespace RentalApp.DATA.Repositories
{
    public class VehicleInspectionRepository
    {
        // CREATE - Add new inspection
        public int Add(VehicleInspection inspection)
        {
            string sql = @"INSERT INTO vehicleinspections 
                          (RentalID, InspectionType, InspectedBy, InspectionDate, Mileage, FuelLevel, 
                           InteriorCondition, ExteriorCondition, HasSmokingViolation, 
                           AllAccessoriesReturned, Notes) 
                          VALUES (@RentalId, @Type, @InspectedBy, @Date, @Mileage, @FuelLevel, 
                                  @InteriorCondition, @ExteriorCondition, @HasSmokingViolation, 
                                  @AllAccessories, @Notes);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@RentalId", inspection.RentalId);
                    cmd.Parameters.AddWithValue("@Type", inspection.Type.ToString());
                    cmd.Parameters.AddWithValue("@InspectedBy", inspection.InspectedBy);
                    cmd.Parameters.AddWithValue("@Date", inspection.InspectionDate);
                    cmd.Parameters.AddWithValue("@Mileage", inspection.Mileage);
                    cmd.Parameters.AddWithValue("@FuelLevel", inspection.Fuel.ToString());
                    cmd.Parameters.AddWithValue("@InteriorCondition", inspection.InteriorCondition.ToString());
                    cmd.Parameters.AddWithValue("@ExteriorCondition", inspection.ExteriorCondition.ToString());
                    cmd.Parameters.AddWithValue("@HasSmokingViolation", inspection.HasSmokingViolation ? 1 : 0);
                    cmd.Parameters.AddWithValue("@AllAccessories", inspection.AllAccessoriesReturned ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Notes", inspection.Notes ?? "");

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ - Get inspection by ID
        public VehicleInspection GetById(int id)
        {
            string sql = "SELECT * FROM vehicleinspections WHERE ID = @Id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapReaderToInspection(reader);
                        }
                    }
                }
            }
            return null;
        }

        // READ - Get inspections by rental ID
        public List<VehicleInspection> GetByRentalId(int rentalId)
        {
            var inspections = new List<VehicleInspection>();
            string sql = "SELECT * FROM vehicleinspections WHERE RentalID = @RentalId ORDER BY InspectionDate DESC";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@RentalId", rentalId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            inspections.Add(MapReaderToInspection(reader));
                        }
                    }
                }
            }
            return inspections;
        }

        // READ - Get all inspections
        public List<VehicleInspection> GetAll()
        {
            var inspections = new List<VehicleInspection>();
            string sql = "SELECT * FROM vehicleinspections ORDER BY InspectionDate DESC";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            inspections.Add(MapReaderToInspection(reader));
                        }
                    }
                }
            }
            return inspections;
        }

        // UPDATE - Update inspection
        public void Update(VehicleInspection inspection)
        {
            string sql = @"UPDATE vehicleinspections 
                          SET RentalID = @RentalId, 
                              InspectionType = @Type, 
                              InspectedBy = @InspectedBy,
                              InspectionDate = @Date, 
                              Mileage = @Mileage, 
                              FuelLevel = @FuelLevel, 
                              InteriorCondition = @InteriorCondition, 
                              ExteriorCondition = @ExteriorCondition, 
                              HasSmokingViolation = @HasSmokingViolation, 
                              AllAccessoriesReturned = @AllAccessories, 
                              Notes = @Notes 
                          WHERE ID = @Id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", inspection.Id);
                    cmd.Parameters.AddWithValue("@RentalId", inspection.RentalId);
                    cmd.Parameters.AddWithValue("@Type", inspection.Type.ToString());
                    cmd.Parameters.AddWithValue("@InspectedBy", inspection.InspectedBy);
                    cmd.Parameters.AddWithValue("@Date", inspection.InspectionDate);
                    cmd.Parameters.AddWithValue("@Mileage", inspection.Mileage);
                    cmd.Parameters.AddWithValue("@FuelLevel", inspection.Fuel.ToString());
                    cmd.Parameters.AddWithValue("@InteriorCondition", inspection.InteriorCondition.ToString());
                    cmd.Parameters.AddWithValue("@ExteriorCondition", inspection.ExteriorCondition.ToString());
                    cmd.Parameters.AddWithValue("@HasSmokingViolation", inspection.HasSmokingViolation ? 1 : 0);
                    cmd.Parameters.AddWithValue("@AllAccessories", inspection.AllAccessoriesReturned ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Notes", inspection.Notes ?? "");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE - Delete inspection
        public void Delete(int id)
        {
            string sql = "DELETE FROM vehicleinspections WHERE ID = @Id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Helper method to map reader to VehicleInspection object
        private VehicleInspection MapReaderToInspection(MySqlDataReader reader)
        {
            return new VehicleInspection
            {
                Id = reader.GetInt32("ID"),
                RentalId = reader.GetInt32("RentalID"),
                Type = (InspectionType)Enum.Parse(typeof(InspectionType), reader.GetString("InspectionType")),
                InspectionDate = reader.GetDateTime("InspectionDate"),
                Mileage = reader.GetInt32("Mileage"),
                Fuel = (FuelLevel)Enum.Parse(typeof(FuelLevel), reader.GetString("FuelLevel")),
                InteriorCondition = (Condition)Enum.Parse(typeof(Condition), reader.GetString("InteriorCondition")),
                ExteriorCondition = (Condition)Enum.Parse(typeof(Condition), reader.GetString("ExteriorCondition")),
                InspectedBy = reader.GetInt32("InspectedBy"),
                HasSmokingViolation = reader.GetInt32("HasSmokingViolation") == 1,
                AllAccessoriesReturned = reader.GetInt32("AllAccessoriesReturned") == 1,
                Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? "" : reader.GetString("Notes")
            };
        }
    }
}
