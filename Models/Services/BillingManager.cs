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

        public void CreateInvoice(Invoice invoice)
        {
            invoice.CalculateTotal();

            if (invoice.TotalAmount <= 0)
            {
                throw new Exception("Error: Invoice total cannot be zero or negative.");
            }

            invoice.Id = _invoiceRepository.Add(invoice);
        }

        public List<Invoice> GetUnpaidInvoices()
        {
            return _invoiceRepository.GetUnpaid();
        }

        public void ProcessPayment(Payment payment)
        {
            if (payment.Amount <= 0)
            {
                throw new Exception("Error: Payment amount must be greater than zero.");
            }

            _paymentRepository.Add(payment);

            Invoice invoice = _invoiceRepository.GetById(payment.InvoiceId);
            if (invoice != null)
            {
                invoice.MarkAsPaid();
                _invoiceRepository.Update(invoice);
            }
        }
    }
}
