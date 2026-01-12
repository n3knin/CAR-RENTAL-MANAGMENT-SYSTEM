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
        public string Status { get; set; }
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
            Status = "Active"; // Default status
            
        }
        public string Role => GetRoleName();

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
            // Verify against hash
            string inputHash = ComputeSha256Hash(password);
            // Backward compatibility for existing plain text passwords (optional, useful for dev)
            if (PasswordHash == password) return true; 
            
            return PasswordHash == inputHash;
        }

        public void SetPassword(string password)
        {
            PasswordHash = ComputeSha256Hash(password);
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (System.Security.Cryptography.SHA256 sha256Hash = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public string GetPasswordHash()
        {
            return PasswordHash;
        }


    }
}
