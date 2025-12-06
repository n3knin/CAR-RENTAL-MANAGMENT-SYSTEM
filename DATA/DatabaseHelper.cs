using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace RentalApp.Data
{
    public class DatabaseHelper
    {
        
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RentalDB"].ConnectionString;
        }

        
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(GetConnectionString());
        }

        
        public static bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);
                return false;
            }
        }
    }
}