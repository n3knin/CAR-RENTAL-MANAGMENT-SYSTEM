using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Models.Users
{
    public class Manager : User
    {
        public Manager() : base() { }

        public Manager(int id, string firstName, string lastName, string username)
            : base(id, firstName, lastName, username)
        {
        }

        public override string GetRoleName()
        {
            return "Manager";
        }

        public override bool CanManageFleet()
        {
            return true; // Per user request: Full system access
        }

        public override bool CanManageUsers()
        {
            return true; // Per user request: Full system access
        }

        public override bool CanViewReports()
        {
            return true; // Per user request: Full system access
        }
    }
}
