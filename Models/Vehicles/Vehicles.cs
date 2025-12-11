using System;

namespace RentalApp.Models.Vehicles
{
    public enum VehicleStatus
    {
        Available,
        Rented,
        Reserved,
        Maintenance,
        OutOfService,
        Retired
    }

    public enum TransmissionType
    {
        Manual,
        Automatic
    }

    public enum FuelType
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid
    }

    
    public abstract class Vehicle
    {
        
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public string VIN { get; set; }
        public int CategoryId { get; set; }
        public VehicleStatus Status { get; set; }
        public int Mileage { get; set; }
        public FuelType Fuel { get; set; }
        public TransmissionType Transmission { get; set; }
        public int SeatingCapacity { get; set; }
        public string ImageUrl { get; set; }
        public System.Collections.Generic.List<string> Features { get; set; } = new System.Collections.Generic.List<string>();

        protected Vehicle() { }

        protected Vehicle(int vehicleId, string make, string model, int year, string licensePlate)
        {
            VehicleId = vehicleId;
            Make = make;
            Model = model;
            Year = year;
            LicensePlate = licensePlate;
            Status = VehicleStatus.Available;
        }

       
        public abstract string GetVehicleType();
        public abstract decimal CalculateLateFee(int hoursLate);

        
        public string GetDisplayName()
        {
            return $"{Year} {Make} {Model}";
        }

        public bool IsAvailable()
        {
            return Status == VehicleStatus.Available;
        }

        public void UpdateMileage(int newMileage)
        {
            if (newMileage > Mileage)
            {
                Mileage = newMileage;
            }
        }
    }
}