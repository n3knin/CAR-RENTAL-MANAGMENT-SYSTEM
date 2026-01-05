using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalApp.Data.Repositories;

namespace RentalApp.Models.Services
{
    public class RentalManager
    {
        private RentalRepository _rentalRepository;

        public RentalManager()
        {
            _rentalRepository = new RentalRepository();
        }

        // Get all rentals
        public List<RentalApp.Models.Core.Rental> GetAllRentals()
        {
            return _rentalRepository.GetAll();
        }

        // Get only active rentals (currently out with customers)
        public List<RentalApp.Models.Core.Rental> GetActiveRentals()
        {
            return _rentalRepository.GetActiveRentals();
        }

        // Start a new rental
        public void StartRental(RentalApp.Models.Core.Rental rental)
        {
            // Validation
            if (rental.VehicleId <= 0)
            {
                throw new Exception("Error: A valid Vehicle must be selected.");
            }

            if (rental.CustomerId <= 0)
            {
                throw new Exception("Error: A valid Customer must be selected.");
            }

            if (rental.StartMileage < 0)
            {
                throw new Exception("Error: Start Mileage cannot be negative.");
            }

            // Save to database
            _rentalRepository.Add(rental);
        }

        // Process a vehicle return
        public void ReturnVehicle(RentalApp.Models.Core.Rental rental)
        {
            // Check if miles make sense
            if (rental.EndMileage < rental.StartMileage)
            {
                throw new Exception("Error: End Mileage cannot be less than Start Mileage.");
            }

            // Mark as completed
            rental.Status = RentalApp.Models.Core.RentalStatus.Completed;
            
            // Update the record in database
            _rentalRepository.Update(rental);
        }

        // Find a specific rental
        public RentalApp.Models.Core.Rental GetRentalById(int id)
        {
            return _rentalRepository.GetById(id);
        }

        // Update rental record
        public void UpdateRental(RentalApp.Models.Core.Rental rental)
        {
            if (rental.Id <= 0)
            {
                throw new Exception("Error: Invalid rental ID.");
            }

            _rentalRepository.Update(rental);
        }
    }
}
