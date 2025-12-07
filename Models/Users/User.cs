using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Models.Users
{
    public abstract class User
    {
        public int Id { get; set; }
        public string  Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        protected string PasswordHash { get; set; }
        protected User()
        {

        }
        protected User(int id, string firstname, string lastname, string username)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            
        }
        public abstract string GetRoleName();
        public abstract bool CanManageFleet();
        public abstract bool CanManageUsers();
        public abstract bool CanViewReports();

        public string GetFullName()
        {
            return $"{Firstname} {Lastname}";
        }
        public bool VerifyPassword(string password)
        {
            
            return PasswordHash == password;
        }
        public void SetPassword(string password)
        {
           
            PasswordHash = password;
        }

    }
}
