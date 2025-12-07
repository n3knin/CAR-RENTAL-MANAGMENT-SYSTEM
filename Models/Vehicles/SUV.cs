using System;

namespace RentalApp.Models.Vehicles
{
    public class SUV : Vehicle
    {
        public SUV() : base() { }

        public SUV(int vehicleId, string make, string model, int year, string licensePlate)
            : base(vehicleId, make, model, year, licensePlate)
        {
            SeatingCapacity = 7;
        }

        public override string GetVehicleType()
        {
            return "SUV";
        }

        public override decimal CalculateLateFee(int hoursLate)
        {
            return hoursLate * 15m;
        }
    }
}
