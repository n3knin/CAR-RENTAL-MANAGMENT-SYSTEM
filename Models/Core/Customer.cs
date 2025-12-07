using System;

namespace RentalApp.Models.Core
{
    public class Customer
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DriverLicenseNumber { get; set; }
        public DateTime? LicenseIssueDate { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
        public string LicenseState { get; set; }
        public string EmergencyContact { get; set; }
        public CustomerType Type { get; set; }
        public bool IsBlacklisted { get; set; }
        public DateTime CreatedAt { get; set; }

        // Constructor
        public Customer()
        {
            CreatedAt = DateTime.Now;
            IsBlacklisted = false;
            Type = CustomerType.Individual;
        }

        // Methods
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        public bool IsLicenseValid()
        {
            return LicenseExpiryDate > DateTime.Now;
        }

        public bool IsEligibleToRent()
        {
            return GetAge() >= 21 && IsLicenseValid() && !IsBlacklisted;
        }
    }

    public enum CustomerType
    {
        Individual,
        Corporate
    }
}
