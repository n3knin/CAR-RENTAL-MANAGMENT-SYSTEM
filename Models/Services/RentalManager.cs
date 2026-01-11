using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalApp.Data.Repositories;
using RentalApp.Models.Core;

namespace RentalApp.Models.Services
{
    public class RentalManager
    {
        private RentalRepository _rentalRepository;

        public RentalManager()
        {
            _rentalRepository = new RentalRepository();
        }

        public List<Rental> GetAllRentals()
        {
            return _rentalRepository.GetAll();
        }

        public List<Rental> GetActiveRentals()
        {
            return _rentalRepository.GetActiveRentals();
        }

      
        public void StartRental(Rental rental)
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

            // Capture the new ID and assign it back to the rental object
            int newId = _rentalRepository.Add(rental);
            rental.Id = newId;
        }

        public void ReturnVehicle(Rental rental)
        {
            if (rental.EndMileage < rental.StartMileage)
            {
                throw new Exception("Error: End Mileage cannot be less than Start Mileage.");
            }
            rental.Status = RentalApp.Models.Core.RentalStatus.Completed;
            
            _rentalRepository.Update(rental);
        }

        public Rental GetRentalById(int id)
        {
            return _rentalRepository.GetById(id);
        }

        public void UpdateRental(Rental rental)
        {
            if (rental.Id <= 0)
            {
                throw new Exception("Error: Invalid rental ID.");
            }

            _rentalRepository.Update(rental);
        }

        public int CountTodayPickups()
        {
            return _rentalRepository.CountTodayPickups();
        }

        public int CountActive()
        {
            return _rentalRepository.CountActive();
        }

        public int CountCompleted()
        {
            return _rentalRepository.CountCompleted();
        }
        public int CountPendingReturns()
        {
            return _rentalRepository.CountPendingReturns();
        }

        public bool HasActiveRental(int customerId)
        {
            return _rentalRepository.GetActiveRentalCount(customerId) > 0;
        }

        public void UpdateRentalStatus(int rentalId, string status)
        {
            // Implementation of UpdateRentalStatus if needed, or use existing Update method
            var rental = _rentalRepository.GetById(rentalId);
            if (rental != null)
            {
                if (Enum.TryParse<RentalApp.Models.Core.RentalStatus>(status, out var rentalStatus))
                {
                    rental.Status = rentalStatus;
                    _rentalRepository.Update(rental);
                }
            }
        }
        public List<Rental> GetByDateRange(DateTime start, DateTime end)
        {
            return _rentalRepository.GetByDateRange(start, end);
        }

        public double GetAverageRentalDuration(DateTime start, DateTime end)
        {
            return _rentalRepository.GetAverageRentalDuration(start, end);
        }

        public double GetDamageIncidentRate(DateTime start, DateTime end)
        {
            return _rentalRepository.GetDamageIncidentRate(start, end);
        }

        public int GetTotalRentalDays(DateTime start, DateTime end)
        {
            return _rentalRepository.GetTotalRentalDays(start, end);
        }
    }
}
