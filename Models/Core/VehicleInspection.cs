using System;

namespace RentalApp.Models.Core
{
    public class VehicleInspection
    {
        // Properties matching VehicleInspections table
        public int Id { get; set; }
        public int RentalId { get; set; }
        public InspectionType Type { get; set; }
        public DateTime InspectionDate { get; set; }
        public int InspectedBy { get; set; }
        public int Mileage { get; set; }
        public FuelLevel Fuel { get; set; }
        public Condition ExteriorCondition { get; set; }
        public Condition InteriorCondition { get; set; }
        public bool HasSmokingViolation { get; set; }
        public bool AllAccessoriesReturned { get; set; }
        public string Notes { get; set; }

        // Navigation properties
        public Rental Rental { get; set; }
        public Users.User Inspector { get; set; }

        // Constructor
        public VehicleInspection()
        {
            InspectionDate = DateTime.Now;
            AllAccessoriesReturned = true;
            HasSmokingViolation = false;
        }

        // Methods
        public bool HasDamage()
        {
            return ExteriorCondition == Condition.Poor || InteriorCondition == Condition.Poor;
        }

        public bool NeedsCleaning()
        {
            return InteriorCondition == Condition.Poor || HasSmokingViolation;
        }
    }

    public enum InspectionType
    {
        Pickup,
        Return
    }

    public enum FuelLevel
    {
        Empty,
        Quarter,
        Half,
        ThreeQuarter,
        Full
    }

    public enum Condition
    {
        Excellent,
        Good,
        Fair,
        Poor
    }
}
