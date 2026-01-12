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
        public Invoice GetInvoiceById(int id)
        {
            return _invoiceRepository.GetById(id);
        }

        public Invoice GetInvoiceByRentalId(int rentalId)
        {
            return _invoiceRepository.GetByRentalId(rentalId);
        }
        public int CountToday()
        {
            return _invoiceRepository.CountToday();
        }
        public decimal SumInvoicedToday()
        {
            return _invoiceRepository.SumInvoicedToday();
        }
        public decimal SumRevenue()
        {
            return _invoiceRepository.SumRevenue();
        }
        public List<Invoice> GetAllPaid()
        {
            return _invoiceRepository.GetAllPaid();
        }

        public Dictionary<int, decimal> GetWeeklySalesTrend()
        {
            return _invoiceRepository.GetWeeklyRevenue();
        }

        public List<ReportRow> GetReportData(DateTime start, DateTime end)
        {
            return _invoiceRepository.GetReportData(start, end);
        }

        public Dictionary<string, decimal> GetMonthlyRevenue(int count = 6)
        {
            return _invoiceRepository.GetMonthlyRevenue(count);
        }

        public Dictionary<string, int> GetCategoryUsageCurrentMonth()
        {
            return _invoiceRepository.GetCategoryUsageCurrentMonth();
        }
        public decimal GetRevenuePerVehicle(DateTime start, DateTime end)
        {
            return _invoiceRepository.GetRevenuePerVehicle(start, end);
        }
    }
}
