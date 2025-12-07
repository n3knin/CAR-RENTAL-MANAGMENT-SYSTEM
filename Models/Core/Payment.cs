using System;

namespace RentalApp.Models.Core
{
    public class Payment
    {
        // Properties matching Payments table
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod Method { get; set; }

        // Navigation property
        public Invoice Invoice { get; set; }

        // Constructor
        public Payment()
        {
            PaymentDate = DateTime.Now;
        }

        public Payment(int invoiceId, decimal amount, PaymentMethod method)
        {
            InvoiceId = invoiceId;
            Amount = amount;
            Method = method;
            PaymentDate = DateTime.Now;
        }
    }

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        Online
    }
}
