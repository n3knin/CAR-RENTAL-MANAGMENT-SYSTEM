using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalApp.Data.Repositories;
using RentalApp.Models.Core;
using RentalApp.Models.Vehicles;

namespace RentalApp.Models.Services
{
    public class MaintenanceManager
    {
        private MaintenanceRepository _maintenanceRepository;
        private VehicleRepository _vehicleRepository;

        public MaintenanceManager()
        {
            _maintenanceRepository = new MaintenanceRepository();
            _vehicleRepository = new VehicleRepository();
        }

        // Send a car to the shop
        public void ScheduleMaintenance(MaintenanceRecord record)
        {
            // Basic check
            if (record.VehicleId <= 0)
            {
                throw new Exception("Error: You must select a valid vehicle.");
            }

            // 1. Save the maintenance record
            _maintenanceRepository.Add(record);

            // 2. IMPORTANT: Update the car's status to 'Maintenance' so nobody rents it!
            _vehicleRepository.UpdateStatus(record.VehicleId, VehicleStatus.Maintenance);
        }

        // Car is fixed, bring it back
        public void CompleteMaintenance(int maintenanceId, int vehicleId)
        {
            // 1. Mark the job as done in history
            _maintenanceRepository.CompleteMaintenance(maintenanceId, DateTime.Now);

            // 2. Mark the car as 'Available' again
            _vehicleRepository.UpdateStatus(vehicleId, VehicleStatus.Available);
        }

        // See history for a car
        public List<MaintenanceRecord> GetHistory(int vehicleId)
        {
            return _maintenanceRepository.GetByVehicleId(vehicleId);
        }
        public int CountMaintenanceRecords(int vehicleId)
        {
            return _maintenanceRepository.CountMaintenanceRecords(vehicleId);
        }
    }
}
