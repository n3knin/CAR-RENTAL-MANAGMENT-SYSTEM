using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalApp.Data.Repositories;
using RentalApp.Models.Vehicles;
using RentalApp.Models.Core;

namespace RentalApp.Models.Services
{
    public class VehicleManager
    {
        private VehicleRepository _vehicleRepository;


        public VehicleManager()
        {
            _vehicleRepository = new VehicleRepository();
        }

        public int Add(Vehicle vehicle)
        {

            if (string.IsNullOrEmpty(vehicle.Make) || string.IsNullOrEmpty(vehicle.Model))
            {
                throw new ArgumentException("Make and Model are required.");
            }

            if (vehicle.Year < 1900 || vehicle.Year > DateTime.Now.Year)
            {
                throw new ArgumentException("Year must be between 1900 and the current year.");
            }

            if (string.IsNullOrEmpty(vehicle.Color))
            {
                throw new ArgumentException("Color is required.");
            }

            if (string.IsNullOrEmpty(vehicle.LicensePlate))
            {
                throw new ArgumentException("License Plate is required.");
            }

            if (string.IsNullOrEmpty(vehicle.VIN))
            {
                throw new ArgumentException("VIN is required.");
            }

            if (vehicle.CategoryId == 0)
            {
                throw new ArgumentException("Category is required.");
            }


            if (vehicle.Mileage < 0)
            {
                throw new ArgumentException("Mileage must be greater than or equal to 0.");
            }

            if (vehicle.SeatingCapacity < 1)
            {
                throw new ArgumentException("Seating Capacity must be greater than 0.");
            }   

            return _vehicleRepository.Add(vehicle);
        }

        public List<Vehicle> GetAllVehicles()
        {
            return _vehicleRepository.GetAll();
        }

        public Vehicle GetVehicleById(int id)
        {
            return _vehicleRepository.GetById(id);
        }

        public List<Vehicle> GetAvailableVehicles()
        {
            return _vehicleRepository.GetAvailable();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            // Basic validation for update (similar to Add but simpler)
            if (string.IsNullOrEmpty(vehicle.Make) || string.IsNullOrEmpty(vehicle.Model))
            {
                throw new ArgumentException("Make and Model are required.");
            }
           

            _vehicleRepository.Update(vehicle);
        }

        public void DeleteVehicle(int id)
        {
            _vehicleRepository.Delete(id);
        }

        public void UpdateVehicleStatus(int id, VehicleStatus status)
        {
            _vehicleRepository.UpdateStatus(id, status);
        }
        public int CountAvailable()
        {
            return _vehicleRepository.CountAvailable();
        }
        public int CountRented()
        {
            return _vehicleRepository.CountRented();
        }
        public void RetireVehicle(int id)
        {
            _vehicleRepository.RetireVehicle(id);
        }
        public int CountAll()
        {
            return _vehicleRepository.CountAll();
        }
        public string GetVehicleStatus(int id)
        {
            return _vehicleRepository.GetVehicleStatus(id);
        }

        public Dictionary<string, int> GetFleetDistribution()
        {
            return _vehicleRepository.GetFleetDistribution();
        }
    }
}
