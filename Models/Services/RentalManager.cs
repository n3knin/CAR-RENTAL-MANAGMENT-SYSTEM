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

        // Start a new rental
        public void StartRental(Rental rental)
        {
            // Simple validation checks
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
        public void ReturnVehicle(Rental rental)
        {
            // Check if miles make sense
            if (rental.EndMileage < rental.StartMileage)
            {
                throw new Exception("Error: End Mileage cannot be less than Start Mileage.");
            }

            // Mark as completed
            rental.Status = RentalStatus.Completed;
            
            // Update the record in database
            _rentalRepository.Update(rental);
        }

        // Get list of all rentals
        public List<Rental> GetAllRentals()
        {
            return _rentalRepository.GetAll();
        }

        // Get only the cars currently out
        public List<Rental> GetActiveRentals()
        {
            return _rentalRepository.GetActiveRentals();
        }

        // Find a specific rental
        public Rental GetRentalById(int id)
        {
            return _rentalRepository.GetById(id);
        }
    }
}
