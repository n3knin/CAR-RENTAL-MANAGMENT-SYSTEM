using System;

namespace RentalApp.Models.Core
{
    public class MaintenanceRecord
    {
        // Properties matching MaintenanceRecords table
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public MaintenanceType Type { get; set; }
        public decimal Cost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCompleted { get; set; }

        // Navigation property
        public Vehicles.Vehicle Vehicle { get; set; }

        // Constructor
        public MaintenanceRecord() { }

        public MaintenanceRecord(int vehicleId, MaintenanceType type, decimal cost)
        {
            VehicleId = vehicleId;
            Type = type;
            Cost = cost;
            StartDate = DateTime.Now;
        }

        // Methods
        public void Complete()
        {
            EndDate = DateTime.Now;
            IsCompleted = true;
        }
        public enum MaintenanceType { 
            OilChange,
            TireRotation,
            BrakeService,
            AirFilterReplacement,
            SparkPlugsReplacement,
            EngineService,
            ElectricalService,
            CoolingSystemService,
            ExhaustService,
            FuelSystemService
        }

        public TimeSpan? GetDuration()
        {
            if (EndDate.HasValue)
            {
                return EndDate.Value - StartDate;
            }
            return null;
        }
    }
}
