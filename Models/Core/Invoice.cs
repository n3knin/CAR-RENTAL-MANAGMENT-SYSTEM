using System;

namespace RentalApp.Models.Core
{
    public class Invoice
    {
        // Properties matching Invoices table
        public int Id { get; set; }
        public int RentalId { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal RentalCharge { get; set; }
        public RateType? AppliedRateType { get; set; }
        public decimal LateFee { get; set; }
        public decimal DamageFee { get; set; }
        public decimal FuelCharge { get; set; }
        public decimal CleaningFee { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsPaid { get; set; }

        // Navigation property
        public Rental Rental { get; set; }

        // Constructor
        public Invoice()
        {
            IssueDate = DateTime.Now;
            IsPaid = false;
        }

        // Methods
        public void CalculateTotal()
        {
            TotalAmount = RentalCharge + LateFee + DamageFee + FuelCharge + CleaningFee;
        }

        public void MarkAsPaid()
        {
            IsPaid = true;
        }

        public decimal GetBalance()
        {
            return IsPaid ? 0 : TotalAmount;
        }
    }

    public enum RateType
    {
        Hourly,
        Daily,
        Weekly,
        Monthly
    }
}
