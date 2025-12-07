using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Vehicles;

namespace RentalApp.Data.Repositories
{
    public class VehicleRepository
    {
        // CREATE - Add new vehicle
        public int Add(Vehicle vehicle)
        {
            string sql = @"INSERT INTO Vehicles 
                          (Make, Model, Year, Color, LicensePlate, VIN, CategoryID, 
                           Status, Mileage, FuelType, Transmission, SeatingCapacity, ImageUrl) 
                          VALUES 
                          (@make, @model, @year, @color, @plate, @vin, @catId, 
                           @status, @mileage, @fuel, @trans, @seats, @img);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@make", vehicle.Make);
                    cmd.Parameters.AddWithValue("@model", vehicle.Model);
                    cmd.Parameters.AddWithValue("@year", vehicle.Year);
                    cmd.Parameters.AddWithValue("@color", vehicle.Color ?? "");
                    cmd.Parameters.AddWithValue("@plate", vehicle.LicensePlate);
                    cmd.Parameters.AddWithValue("@vin", vehicle.VIN);
                    cmd.Parameters.AddWithValue("@catId", vehicle.CategoryId);
                    cmd.Parameters.AddWithValue("@status", vehicle.Status.ToString());
                    cmd.Parameters.AddWithValue("@mileage", vehicle.Mileage);
                    cmd.Parameters.AddWithValue("@fuel", vehicle.Fuel.ToString());
                    cmd.Parameters.AddWithValue("@trans", vehicle.Transmission.ToString());
                    cmd.Parameters.AddWithValue("@seats", vehicle.SeatingCapacity);
                    cmd.Parameters.AddWithValue("@img", vehicle.ImageUrl ?? "");

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ - Get all vehicles
        public List<Vehicle> GetAll()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string sql = "SELECT * FROM Vehicles ORDER BY Make, Model";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vehicles.Add(MapReaderToVehicle(reader));
                        }
                    }
                }
            }

            return vehicles;
        }

        // READ - Get vehicle by ID
        public Vehicle GetById(int id)
        {
            string sql = "SELECT * FROM Vehicles WHERE ID = @id";

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
                            return MapReaderToVehicle(reader);
                        }
                    }
                }
            }

            return null;
        }

        // READ - Get available vehicles
        public List<Vehicle> GetAvailable()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string sql = "SELECT * FROM Vehicles WHERE Status = 'Available'";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vehicles.Add(MapReaderToVehicle(reader));
                        }
                    }
                }
            }

            return vehicles;
        }

        // READ - Get vehicles by category
        public List<Vehicle> GetByCategory(int categoryId)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string sql = "SELECT * FROM Vehicles WHERE CategoryID = @catId";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@catId", categoryId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vehicles.Add(MapReaderToVehicle(reader));
                        }
                    }
                }
            }

            return vehicles;
        }

        // UPDATE - Update vehicle
        public void Update(Vehicle vehicle)
        {
            string sql = @"UPDATE Vehicles SET 
                          Make = @make, Model = @model, Year = @year, 
                          Color = @color, LicensePlate = @plate, VIN = @vin,
                          CategoryID = @catId, Status = @status, Mileage = @mileage,
                          FuelType = @fuel, Transmission = @trans, 
                          SeatingCapacity = @seats, ImageUrl = @img
                          WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", vehicle.VehicleId);
                    cmd.Parameters.AddWithValue("@make", vehicle.Make);
                    cmd.Parameters.AddWithValue("@model", vehicle.Model);
                    cmd.Parameters.AddWithValue("@year", vehicle.Year);
                    cmd.Parameters.AddWithValue("@color", vehicle.Color ?? "");
                    cmd.Parameters.AddWithValue("@plate", vehicle.LicensePlate);
                    cmd.Parameters.AddWithValue("@vin", vehicle.VIN);
                    cmd.Parameters.AddWithValue("@catId", vehicle.CategoryId);
                    cmd.Parameters.AddWithValue("@status", vehicle.Status.ToString());
                    cmd.Parameters.AddWithValue("@mileage", vehicle.Mileage);
                    cmd.Parameters.AddWithValue("@fuel", vehicle.Fuel.ToString());
                    cmd.Parameters.AddWithValue("@trans", vehicle.Transmission.ToString());
                    cmd.Parameters.AddWithValue("@seats", vehicle.SeatingCapacity);
                    cmd.Parameters.AddWithValue("@img", vehicle.ImageUrl ?? "");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // UPDATE - Update vehicle status
        public void UpdateStatus(int vehicleId, VehicleStatus status)
        {
            string sql = "UPDATE Vehicles SET Status = @status WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", vehicleId);
                    cmd.Parameters.AddWithValue("@status", status.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE - Delete vehicle
        public void Delete(int id)
        {
            string sql = "DELETE FROM Vehicles WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // HELPER - Map database reader to Vehicle object
        private Vehicle MapReaderToVehicle(MySqlDataReader reader)
        {
            // For now, create a generic Sedan (you can improve this later)
            Vehicle vehicle = new Sedan();

            vehicle.VehicleId = reader.GetInt32("ID");
            vehicle.Make = reader.GetString("Make");
            vehicle.Model = reader.GetString("Model");
            vehicle.Year = reader.GetInt32("Year");
            vehicle.Color = reader.IsDBNull(reader.GetOrdinal("Color")) ? "" : reader.GetString("Color");
            vehicle.LicensePlate = reader.GetString("LicensePlate");
            vehicle.VIN = reader.GetString("VIN");
            vehicle.CategoryId = reader.GetInt32("CategoryID");
            vehicle.Status = (VehicleStatus)Enum.Parse(typeof(VehicleStatus), reader.GetString("Status"));
            vehicle.Mileage = reader.GetInt32("Mileage");
            vehicle.Fuel = (FuelType)Enum.Parse(typeof(FuelType), reader.GetString("FuelType"));
            vehicle.Transmission = (TransmissionType)Enum.Parse(typeof(TransmissionType), reader.GetString("Transmission"));
            vehicle.SeatingCapacity = reader.GetInt32("SeatingCapacity");
            vehicle.ImageUrl = reader.IsDBNull(reader.GetOrdinal("ImageUrl")) ? "" : reader.GetString("ImageUrl");

            return vehicle;
        }
    }
}