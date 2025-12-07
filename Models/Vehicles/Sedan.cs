using System;

namespace RentalApp.Models.Vehicles
{
    public class Sedan : Vehicle
    {
        public Sedan() : base() { }

        public Sedan(int vehicleId, string make, string model, int year, string licensePlate)
            : base(vehicleId, make, model, year, licensePlate)
        {
            SeatingCapacity = 5;
        }

        public override string GetVehicleType()
        {
            return "Sedan";
        }

        public override decimal CalculateLateFee(int hoursLate)
        {
            return hoursLate * 10m;
        }
    }
}
