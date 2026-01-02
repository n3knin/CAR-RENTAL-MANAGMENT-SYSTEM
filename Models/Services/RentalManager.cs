using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalApp.Data.Repositories;

namespace RentalApp.Models.Services
{
    public class RentalManager
    {
        private RentalRepository _rentalRepository;

        public RentalManager()
        {
            _rentalRepository = new RentalRepository();
        }
    }
}
