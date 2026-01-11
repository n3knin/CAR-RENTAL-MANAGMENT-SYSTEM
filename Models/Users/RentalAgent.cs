using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Models.Users
{
    public class RentalAgent : User
    {
        public RentalAgent() :base() { }

        public RentalAgent(int id, string firstName, string lastName, string username)
           : base(id, firstName, lastName, username)
        {
        }
        
        public override string GetRoleName()
        {
            return "RentalAgent";
        }
        public override bool CanManageFleet()
        {
            return false; 
        }
        public override bool CanManageUsers()
        {
            return false; 
        }
        public override bool CanViewReports()
        {
            return false; 
        }
        
        public void ProcessRental()
        {
            
        }
        public void ProcessReturn()
        {
            
        }
        public void RegisterCustomer()
        {
            
        }
    }
}
