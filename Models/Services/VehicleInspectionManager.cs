using System;
using System.Collections.Generic;
using RentalApp.DATA.Repositories;
using RentalApp.Models.Core;

namespace RentalApp.Models.Services
{
    public class VehicleInspectionManager
    {
        private VehicleInspectionRepository _inspectionRepository;

        public VehicleInspectionManager()
        {
            _inspectionRepository = new VehicleInspectionRepository();
        }

        // Add new inspection with validation
        public int AddInspection(VehicleInspection inspection)
        {
            // Validation
            if (inspection.RentalId <= 0)
            {
                throw new ArgumentException("Valid Rental ID is required.");
            }

            if (inspection.Mileage < 0)
            {
                throw new ArgumentException("Mileage cannot be negative.");
            }

            // Set inspection date if not provided
            if (inspection.InspectionDate == DateTime.MinValue)
            {
                inspection.InspectionDate = DateTime.Now;
            }

            return _inspectionRepository.Add(inspection);
        }

        // Get inspection by ID
        public VehicleInspection GetInspectionById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid inspection ID.");
            }

            return _inspectionRepository.GetById(id);
        }

        // Get all inspections for a rental
        public List<VehicleInspection> GetInspectionsByRentalId(int rentalId)
        {
            if (rentalId <= 0)
            {
                throw new ArgumentException("Invalid rental ID.");
            }

            return _inspectionRepository.GetByRentalId(rentalId);
        }

        // Get all inspections
        public List<VehicleInspection> GetAllInspections()
        {
            return _inspectionRepository.GetAll();
        }

        // Update inspection
        public void UpdateInspection(VehicleInspection inspection)
        {
            if (inspection.Id <= 0)
            {
                throw new ArgumentException("Invalid inspection ID.");
            }

            if (inspection.RentalId <= 0)
            {
                throw new ArgumentException("Valid Rental ID is required.");
            }

            _inspectionRepository.Update(inspection);
        }

        // Delete inspection
        public void DeleteInspection(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid inspection ID.");
            }

            _inspectionRepository.Delete(id);
        }

        // Check if inspection has damage
        public bool HasDamage(VehicleInspection inspection)
        {
            return inspection.HasDamage();
        }

        // Check if all accessories returned
        public bool AllAccessoriesReturned(VehicleInspection inspection)
        {
            return inspection.AllAccessoriesReturned;
        }

        // Calculate damage fee (if applicable)
        public decimal CalculateDamageFee(VehicleInspection inspection)
        {
            if (!HasDamage(inspection))
            {
                return 0;
            }

            // Base damage fee
            decimal baseFee = 100.00m;

            // Increase fee based on severity
            if (inspection.ExteriorCondition == Condition.Poor || inspection.InteriorCondition == Condition.Poor)
            {
                baseFee += 200.00m;
            }

            return baseFee;
        }

        // Calculate fuel charge (if not returned full)
        public decimal CalculateFuelCharge(VehicleInspection inspection)
        {
            decimal fuelCharge = 0;

            switch (inspection.Fuel)
            {
                case FuelLevel.ThreeQuarter:
                    fuelCharge = 15.00m;
                    break;
                case FuelLevel.Half:
                    fuelCharge = 30.00m;
                    break;
                case FuelLevel.Quarter:
                    fuelCharge = 45.00m;
                    break;
                case FuelLevel.Empty:
                    fuelCharge = 60.00m;
                    break;
                case FuelLevel.Full:
                default:
                    fuelCharge = 0;
                    break;
            }

            return fuelCharge;
        }

        // Get inspection summary
        public string GetInspectionSummary(VehicleInspection inspection)
        {
            var summary = $"Inspection Date: {inspection.InspectionDate:MM/dd/yyyy hh:mm tt}\n";
            summary += $"Type: {inspection.Type}\n";
            summary += $"Mileage: {inspection.Mileage:N0}\n";
            summary += $"Fuel Level: {inspection.Fuel}\n";
            summary += $"Interior: {inspection.InteriorCondition}\n";
            summary += $"Exterior: {inspection.ExteriorCondition}\n";
            summary += $"Damage: {(HasDamage(inspection) ? "Yes" : "No")}\n";
            summary += $"All Accessories: {(inspection.AllAccessoriesReturned ? "Yes" : "No")}\n";
            summary += $"Smoking Violation: {(inspection.HasSmokingViolation ? "Yes" : "No")}\n";

            if (!string.IsNullOrEmpty(inspection.Notes))
            {
                summary += $"Notes: {inspection.Notes}\n";
            }

            return summary;
        }
    }
}
