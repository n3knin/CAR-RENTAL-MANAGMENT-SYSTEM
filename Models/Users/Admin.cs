using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Models.Users
{
    public class Admin : User
    {
        public Admin() :base () { }

        public Admin(int id, string firstName, string lastName, string username)
            : base(id, firstName, lastName, username)
        {
        }
      
        public override string GetRoleName()
        {
            return "Admin";
        }
        public override bool CanManageFleet()
        {
            return true; 
        }
        public override bool CanManageUsers()
        {
            return true;
        }
        public override bool CanViewReports()
        {
            return true; 
        }

        public void ApproveMaintenanceRequest()
        {
           
        }
        public void ManageRates()
        {
            
        }
    }
}
