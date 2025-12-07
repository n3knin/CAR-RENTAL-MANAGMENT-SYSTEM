using System;

namespace RentalApp.Models.Vehicles
{
    public class Van : Vehicle
    {
        public Van() : base() { }

        public Van(int vehicleId, string make, string model, int year, string licensePlate)
            : base(vehicleId, make, model, year, licensePlate)
        {
            SeatingCapacity = 8;
        }

        public override string GetVehicleType()
        {
            return "Van";
        }

        public override decimal CalculateLateFee(int hoursLate)
        {
            return hoursLate * 18m;
        }
    }
}
