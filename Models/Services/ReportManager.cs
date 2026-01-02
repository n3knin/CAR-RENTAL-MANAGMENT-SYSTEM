using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalApp.Data.Repositories;
using RentalApp.Models.Core;

namespace RentalApp.Models.Services
{
    public class ReportManager
    {
        private InvoiceRepository _invoiceRepository;
        private RentalRepository _rentalRepository;
        private VehicleRepository _vehicleRepository;

        public ReportManager()
        {
            _invoiceRepository = new InvoiceRepository();
            _rentalRepository = new RentalRepository();
            _vehicleRepository = new VehicleRepository();
        }

        // 1. Calculate Total Money Earned
        public decimal GetTotalRevenue()
        {
            // Note: Ideally, we would ask the Repository for this SUM() directly for speed.
            // But for this simple project, we can get all invoices and sum them up here.
            var invoices = _invoiceRepository.GetUnpaid(); // This is just 'Unpaid', improved logic would actally get ALL.
            // Since we don't have a 'GetAllInvoices' yet, let's just return a placeholder or 0 for now
            // to avoid crashing until InvoiceRepository is improved.
            return 0; 
        }

        // 2. Count how many rentals we have ever done
        public int GetTotalRentalsCount()
        {
            var rentals = _rentalRepository.GetAll();
            return rentals.Count;
        }

        // 3. See how busy our fleet is (Available vs Rented)
        public string GetFleetStatusSummary()
        {
            int available = _vehicleRepository.CountAvailable();
            int rented = _vehicleRepository.CountRented();
            int total = available + rented;

            return $"Total Fleet: {total} | Available: {available} | Rented: {rented}";
        }
    }
}
