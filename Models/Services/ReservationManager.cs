using System;
using System.Collections.Generic;
using RentalApp.Data.Repositories;
using RentalApp.Models.Core;

namespace RentalApp.Models.Services
{
    public class ReservationManager
    {
        private ReservationRepository _reservationRepository;

        public ReservationManager()
        {
            _reservationRepository = new ReservationRepository();
        }

        // 1. Used by the "Reservations Tab" (See all transactions)
        public List<Reservation> GetAllReservations()
        {
            return _reservationRepository.GetAll();
        }

        // 2. Used by the "Customer Tab" (See specific history)
        public List<Reservation> GetCustomerHistory(int customerId)
        {
            return _reservationRepository.GetByCustomer(customerId);
        }

        // 3. Logic to add a booking (preventing conflicts would go here later)
        public void CreateReservation(Reservation reservation)
        {
             // Basic Validation
             if (reservation.EndDate <= reservation.StartDate)
             {
                 throw new ArgumentException("End date must be after start date.");
             }

             _reservationRepository.Add(reservation);
        }

        public void CancelReservation(int id)
        {
             var reservation = _reservationRepository.GetById(id);
             if (reservation != null)
             {
                 reservation.Status = ReservationStatus.Cancelled;
                 _reservationRepository.Update(reservation);
             }
        }
    }
}
