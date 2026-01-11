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

             int newId = _reservationRepository.Add(reservation);
             reservation.Id = newId;
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
        public int CountPending()
        {
            return _reservationRepository.CountPending();
        }
        public int CountConfirmed()
        {
            return _reservationRepository.CountConfirmed();
        }

        // Get pending reservations
        public List<Reservation> GetAllPending()
        {
            return _reservationRepository.GetAll();
        }

        // Get confirmed reservations
        public List<Reservation> GetConfirmed()
        {
            return _reservationRepository.GetConfirmed();
        }

        public List<Reservation> GetByDateRange(DateTime start, DateTime end)
        {
            return _reservationRepository.GetByDateRange(start, end);
        }

        // Update reservation   
        public void UpdateReservation(Reservation reservation)
        {
            if (reservation.Id <= 0)
            {
                throw new ArgumentException("Invalid reservation ID.");
            }

            if (reservation.EndDate <= reservation.StartDate)
            {
                throw new ArgumentException("End date must be after start date.");
            }

            _reservationRepository.Update(reservation);
        }

        // Update reservation status only
        public void UpdateReservationStatus(int reservationId, ReservationStatus status)
        {
            if (reservationId <= 0)
            {
                throw new ArgumentException("Invalid reservation ID.");
            }

            _reservationRepository.UpdateStatus(reservationId, status);
        }
        public int CountTotal()
        {
            return _reservationRepository.CountTotal();
        }

        public bool HasActiveReservation(int customerId)
        {
            return _reservationRepository.GetActiveReservationCount(customerId) > 0;
        }
        public void DeleteReservation(int id)
        {
            _reservationRepository.Delete(id);
        }
    }
}
