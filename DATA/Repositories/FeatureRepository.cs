using System;
using System.Collections.Generic;
using RentalApp.Models.Vehicles;
using MySql.Data.MySqlClient;
using RentalApp.Data;

namespace RentalApp.Data.Repositories
{
    public class FeatureRepository
    {
        // In the future, this will query the 'VehicleFeatures' table.
        // For now, it returns sample data so the UI can be tested.

        public List<string> GetFeaturesByVehicleId(int vehicleId)
        {
            var features = new List<string>();
            
            string sql = @"SELECT vf.FeatureName
                          FROM vehiclefeatures vf 
                          INNER JOIN vehiclefeaturemap vfm ON vf.ID = vfm.FeatureID 
                          WHERE vfm.VehicleID = @VehicleId
                          ORDER BY vf.FeatureName ASC";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@VehicleId", vehicleId);
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            features.Add(reader.GetString("FeatureName"));
                        }
                    }
                }
            }

            return features;
        }

        // Get all available features from the Features table
        public List<string> GetAllFeatures()
        {
            var features = new List<string>();
            string sql = "SELECT FeatureName FROM vehiclefeatures ORDER BY FeatureName ASC";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            features.Add(reader.GetString("FeatureName"));
                        }
                    }
                }
            }

            return features;
        }

        public void AddFeatureToVehicle(int vehicleId, int featureId)
        {
            string sql = "INSERT INTO vehiclefeaturemap (VehicleID, FeatureID) VALUES (@VehicleId, @FeatureId)";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@VehicleId", vehicleId);
                    cmd.Parameters.AddWithValue("@FeatureId", featureId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Get Feature ID by name
        public int GetFeatureIdByName(string featureName)
        {
            string sql = "SELECT ID FROM vehiclefeatures WHERE FeatureName = @FeatureName";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FeatureName", featureName);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
    }
}
