using System;

namespace RentalApp.Models.Core
{
    public class Deposit
    {
        
        public int Id { get; set; }
        public int RentalId { get; set; }
        public decimal Amount { get; set; }
        public DepositStatus Status { get; set; }
        public decimal RefundedAmount { get; set; }
        public bool AppliedToInvoice { get; set; }

        
        public Rental Rental { get; set; }

        
        public Deposit()
        {
            Status = DepositStatus.Held;
            RefundedAmount = 0;
            AppliedToInvoice = false;
        }

        
        public void Refund(decimal amount)
        {
            RefundedAmount = amount;
            Status = DepositStatus.Refunded;
        }

        public void ApplyToInvoice()
        {
            AppliedToInvoice = true;
            Status = DepositStatus.Applied;
        }
    }

    public enum DepositStatus
    {
        Held,
        Refunded,
        Applied
    }
}
