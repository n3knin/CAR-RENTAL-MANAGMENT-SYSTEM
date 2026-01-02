using System;

namespace RentalApp.Models.Core
{
    public class Reservation
    {
        [System.ComponentModel.Browsable(false)]
        public int Id { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int CustomerId { get; set; }
        
        [System.ComponentModel.Browsable(false)]
        public int VehicleId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ReservationStatus Status { get; set; }

        [System.ComponentModel.Browsable(false)]
        public DateTime CreatedAt { get; set; }

        
        [System.ComponentModel.Browsable(false)]
        public Customer Customer { get; set; }

        [System.ComponentModel.Browsable(false)]
        public Vehicles.Vehicle Vehicle { get; set; }

        // --- DISPLAY PROPERTIES (For DataGridView) ---
        public string CustomerName 
        { 
            get { return Customer != null ? Customer.GetFullName() : "Unknown"; } 
        }

        public string VehicleInfo 
        { 
            get { return Vehicle != null ? Vehicle.GetDisplayName() : "Unknown"; } 
        }
        // ---------------------------------------------

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
