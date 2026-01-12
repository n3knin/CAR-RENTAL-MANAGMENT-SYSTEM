using System;
using System.Security.Cryptography;
using System.Text;

namespace HashGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] passwords = { "admin123", "manager123", "agent123", "div123" };
            
            foreach (string password in passwords)
            {
                string hash = ComputeSha256Hash(password);
                Console.WriteLine($"Password: {password}");
                Console.WriteLine($"Hash: {hash}");
                Console.WriteLine();
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
