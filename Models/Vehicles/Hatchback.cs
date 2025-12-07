using System;

namespace RentalApp.Models.Vehicles
{
    public class Hatchback : Vehicle
    {
        public Hatchback() : base() { }

        public Hatchback(int vehicleId, string make, string model, int year, string licensePlate)
            : base(vehicleId, make, model, year, licensePlate)
        {
            SeatingCapacity = 5;
        }

        public override string GetVehicleType()
        {
            return "Hatchback";
        }

        public override decimal CalculateLateFee(int hoursLate)
        {
            return hoursLate * 8m;
        }
    }
}
