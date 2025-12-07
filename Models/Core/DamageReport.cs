using System;

namespace RentalApp.Models.Core
{
    public class DamageReport
    {
        // Properties matching DamageReports table
        public int Id { get; set; }
        public int InspectionId { get; set; }
        public DamageType Type { get; set; }
        public string Location { get; set; }
        public DamageSeverity Severity { get; set; }
        public string Description { get; set; }
        public decimal EstimatedCost { get; set; }
        public string PhotoUrl { get; set; }

        // Navigation property
        public VehicleInspection Inspection { get; set; }

        // Constructor
        public DamageReport() { }

        public DamageReport(DamageType type, string location, DamageSeverity severity)
        {
            Type = type;
            Location = location;
            Severity = severity;
        }
    }

    public enum DamageType
    {
        Scratch,
        Dent,
        Crack,
        Stain,
        Missing,
        Other
    }

    public enum DamageSeverity
    {
        Minor,
        Moderate,
        Major
    }
}
