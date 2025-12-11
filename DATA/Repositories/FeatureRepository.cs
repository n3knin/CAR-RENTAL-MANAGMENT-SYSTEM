using System;
using System.Collections.Generic;
using RentalApp.Models.Vehicles;

namespace RentalApp.Data.Repositories
{
    public class FeatureRepository
    {
        // In the future, this will query the 'VehicleFeatures' table.
        // For now, it returns sample data so the UI can be tested.

        public List<string> GetFeaturesByVehicleId(int vehicleId)
        {
            var features = new List<string>();

            // TODO: REPLACE WITH REAL SQL
            // string sql = "SELECT f.Name FROM Features f JOIN VehicleFeatures vf ON f.ID = vf.FeatureID WHERE vf.VehicleID = @id";
            
            // Dummy Data Logic
            if (vehicleId % 2 == 0) 
            {
                features.Add("GPS Navigation");
                features.Add("Bluetooth");
                features.Add("Heated Seats");
            }
            else
            {
                 features.Add("Sunroof");
                 features.Add("Apple CarPlay");
            }

            return features;
        }

        public void AddFeatureToVehicle(int vehicleId, string feature)
        {
            // SQL INSERT would go here
        }
    }
}
