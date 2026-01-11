using System;
using System.Collections.Generic;
using RentalApp.Data.Repositories;
using RentalApp.Models.Core;

namespace RentalApp.Models.Services
{
    public class DepositManager
    {
        private DepositRepository _depositRepository;

        public DepositManager()
        {
            _depositRepository = new DepositRepository();
        }

        public void ProcessDeposit(int rentalId, decimal amount)
        {
            var deposit = new Deposit
            {
                RentalId = rentalId,
                Amount = amount,
                Status = DepositStatus.Held
            };
            _depositRepository.Add(deposit);
        }

        public void RefundDeposit(int depositId, decimal refundAmount)
        {
            var deposit = _depositRepository.GetById(depositId);
            if (deposit == null) throw new Exception("Deposit record not found.");

            deposit.Refund(refundAmount);
            _depositRepository.Update(deposit);
        }

        public void ApplyToInvoice(int depositId)
        {
            var deposit = _depositRepository.GetById(depositId);
            if (deposit == null) throw new Exception("Deposit record not found.");

            deposit.ApplyToInvoice();
            _depositRepository.Update(deposit);
        }

        // Get deposit info for a specific rental
        public Deposit GetDepositByRental(int rentalId)
        {
            return _depositRepository.GetByRentalId(rentalId);
        }

        public Deposit GetDepositByRentalId(int rentalId)
        {
            return GetDepositByRental(rentalId);
        }
    }
}
