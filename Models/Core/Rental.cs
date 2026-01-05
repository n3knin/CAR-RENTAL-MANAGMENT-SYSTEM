using System;

namespace RentalApp.Models.Core
{
    public class Rental
    {
        // Properties matching Rentals table
        public int Id { get; set; }
        public int? ReservationId { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public int RentalAgentId { get; set; }
        public DateTime ActualPickupDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
        public int StartMileage { get; set; }
        public int? EndMileage { get; set; }
        public RentalStatus Status { get; set; }
        // Navigation properties
        public Customer Customer { get; set; }
        public Vehicles.Vehicle Vehicle { get; set; }
        public Users.User RentalAgent { get; set; }
        

        // --- DISPLAY PROPERTIES (For DataGridView) ---
        public string CustomerName 
        { 
            get { return Customer != null ? Customer.GetFullName() : "Unknown"; } 
        }

        public string VehicleInfo 
        { 
            get { return Vehicle != null ? Vehicle.GetDisplayName() : "Unknown"; } 
        }
        public string RentalAgentName
        {
            get { return RentalAgent != null ? RentalAgent.GetFullName() : "Unknown"; }
        }
        // ---------------------------------------------

        // Constructor
        public Rental()
        {
            Status = RentalStatus.Active;
            ActualPickupDate = DateTime.Now;
        }

        // Methods
        public TimeSpan? GetActualDuration()
        {
            if (ActualReturnDate.HasValue)
            {
                return ActualReturnDate.Value - ActualPickupDate;
            }
            return null;
        }

        public int? GetMileageDriven()
        {
            if (EndMileage.HasValue)
            {
                return EndMileage.Value - StartMileage;
            }
            return null;
        }

        public bool IsOverdue(DateTime expectedReturnDate)
        {
            if (ActualReturnDate.HasValue)
            {
                return ActualReturnDate.Value > expectedReturnDate;
            }
            return DateTime.Now > expectedReturnDate;
        }

        public void CompleteReturn(int endMileage)
        {
            ActualReturnDate = DateTime.Now;
            EndMileage = endMileage;
            Status = RentalStatus.Completed;
        }
    }

    public enum RentalStatus
    {
        Active,
        Completed,
        Overdue
    }
}
