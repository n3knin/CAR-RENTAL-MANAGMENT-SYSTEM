using System;

namespace RentalApp.Models.Vehicles
{
    public class Pickup : Vehicle
    {
        public double CargoCapacity { get; set; }

        public Pickup() : base() { }

        public Pickup(int vehicleId, string make, string model, int year, string licensePlate)
            : base(vehicleId, make, model, year, licensePlate)
        {
            SeatingCapacity = 5;
        }

        public override string GetVehicleType()
        {
            return "Pickup Truck";
        }

        public override decimal CalculateLateFee(int hoursLate)
        {
            return hoursLate * 12m;
        }
    }
}
