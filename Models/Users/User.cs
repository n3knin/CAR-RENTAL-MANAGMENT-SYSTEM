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
            if (string.IsNullOrEmpty(PasswordHash))
                return false;

            // Hash the input password
            string inputHash = ComputeSha256Hash(password);
            
            // Compare: both hashed input and stored hash (case-insensitive)
            // This handles both scenarios:
            // 1. Stored password is already hashed -> direct comparison
            // 2. Stored password is plain text -> won't match the hash, so we also check plain text
            if (PasswordHash.Equals(inputHash, StringComparison.OrdinalIgnoreCase))
            {
                return true; // Hashed password matches
            }
            
            // Fallback: check if stored password is plain text (backward compatibility)
            if (PasswordHash.Equals(password, StringComparison.Ordinal))
            {
                return true; // Plain text password matches
            }
            
            return false;
        }

        public void SetPassword(string password)
        {
            PasswordHash = ComputeSha256Hash(password);
        }

        // Internal method for repository to set already-hashed password from database
        internal void SetPasswordHash(string hashedPassword)
        {
            PasswordHash = hashedPassword;
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
