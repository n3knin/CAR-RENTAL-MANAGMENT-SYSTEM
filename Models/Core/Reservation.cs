using System;

namespace RentalApp.Models.Core
{
    public class Reservation
    {
        
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ReservationStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        
        public Customer Customer { get; set; }
        public Vehicles.Vehicle Vehicle { get; set; }

        // Constructor
        public Reservation()
        {
            CreatedAt = DateTime.Now;
            Status = ReservationStatus.Pending;
        }

        // Methods
        public TimeSpan GetDuration()
        {
            return EndDate - StartDate;
        }

        public int GetTotalDays()
        {
            return (int)Math.Ceiling(GetDuration().TotalDays);
        }

        public bool IsActive()
        {
            return Status == ReservationStatus.Confirmed || Status == ReservationStatus.Pending;
        }

        public void Confirm()
        {
            Status = ReservationStatus.Confirmed;
        }

        public void Cancel()
        {
            Status = ReservationStatus.Cancelled;
        }
    }

    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        Cancelled,
        Completed
    }
}
