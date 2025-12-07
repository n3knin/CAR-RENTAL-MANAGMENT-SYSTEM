using System;

namespace RentalApp.Models.Core
{
    public class MaintenanceRecord
    {
        // Properties matching MaintenanceRecords table
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Navigation property
        public Vehicles.Vehicle Vehicle { get; set; }

        // Constructor
        public MaintenanceRecord() { }

        public MaintenanceRecord(int vehicleId, string description, decimal cost)
        {
            VehicleId = vehicleId;
            Description = description;
            Cost = cost;
            StartDate = DateTime.Now;
        }

        // Methods
        public bool IsCompleted()
        {
            return EndDate.HasValue;
        }

        public void Complete()
        {
            EndDate = DateTime.Now;
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
