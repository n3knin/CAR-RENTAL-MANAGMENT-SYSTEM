using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalApp.Data.Repositories;
using RentalApp.Models.Core;

namespace RentalApp.Models.Services
{
    public class BillingManager
    {
        private InvoiceRepository _invoiceRepository;
        private PaymentRepository _paymentRepository;

        public BillingManager()
        {
            _invoiceRepository = new InvoiceRepository();
            _paymentRepository = new PaymentRepository();
        }

        // Create a bill for a rental
        public void CreateInvoice(Invoice invoice)
        {
            // Auto-calculate the total before saving
            invoice.CalculateTotal();

            if (invoice.TotalAmount <= 0)
            {
                throw new Exception("Error: Invoice total cannot be zero or negative.");
            }

            _invoiceRepository.Add(invoice);
        }

        // Get bills that are not paid yet
        public List<Invoice> GetUnpaidInvoices()
        {
            return _invoiceRepository.GetUnpaid();
        }

        // Customer pays the bill
        public void ProcessPayment(Payment payment)
        {
            if (payment.Amount <= 0)
            {
                throw new Exception("Error: Payment amount must be greater than zero.");
            }

            // 1. Save the payment record
            _paymentRepository.Add(payment);

            // 2. Update the invoice to say "Pending" or "Paid" (Simplified: We just mark it paid)
            Invoice invoice = _invoiceRepository.GetById(payment.InvoiceId);
            if (invoice != null)
            {
                invoice.MarkAsPaid();
                _invoiceRepository.Update(invoice);
            }
        }
    }
}
