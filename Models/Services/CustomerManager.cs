using System;
using System.Collections.Generic;
using System.Linq;
using RentalApp.Data.Repositories;
using RentalApp.Models.Core;


namespace RentalApp.Models.Services
{
    public class CustomerManager
    {
        private CustomerRepository _customerRepository;

        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }


        public void AddCustomer(Customer customer)
        {
            // VALIDATION FIXES:
            // 1. Strings: Check for null or empty.
            if (string.IsNullOrEmpty(customer.FirstName) ||
                string.IsNullOrEmpty(customer.LastName) ||
                string.IsNullOrEmpty(customer.Email) ||
                string.IsNullOrEmpty(customer.Phone) || // Was 'PhoneNumber'
                string.IsNullOrEmpty(customer.Address))
            {
                throw new ArgumentException("Required fields (Name, Email, Phone, Address) cannot be empty.");
            }

            // 2. Value Types (DateTime, Enum, Int):
            // We don't check for 'null'. We check for valid ranges.
            if (customer.DateOfBirth == DateTime.MinValue)
            {
                throw new ArgumentException("Invalid Date of Birth.");
            }

            // 3. License validation
            if (string.IsNullOrEmpty(customer.DriverLicenseNumber))
            {
                 throw new ArgumentException("Driver License Number is required.");
            }

            _customerRepository.Add(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetById(id);
        }
        public Customer Blacklist(int id) 
        {
            _customerRepository.BlacklistCustomer(id);
            return _customerRepository.GetById(id);
        }
    }
}
