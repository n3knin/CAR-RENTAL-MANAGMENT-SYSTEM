using System;

namespace RentalApp.Models.Core
{
    public class VehicleCategory
    {
        // Properties matching VehicleCategories table
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal DailyRate { get; set; }
        public decimal WeeklyRate { get; set; }
        public decimal MonthlyRate { get; set; }
        public string Description { get; set; }

        // Constructor
        public VehicleCategory() { }

        public VehicleCategory(string categoryName, decimal dailyRate)
        {
            CategoryName = categoryName;
            DailyRate = dailyRate;
        }

        // Methods
        public decimal CalculateRentalCost(DateTime startDate, DateTime endDate)
        {
            TimeSpan duration = endDate - startDate;
            double totalHours = duration.TotalHours;
            double totalDays = duration.TotalDays;

           
            if (totalHours < 24 && HourlyRate > 0)
            {
                return (decimal)Math.Ceiling(totalHours) * HourlyRate;
            }
            else if (totalDays < 7)
            {
                return (decimal)Math.Ceiling(totalDays) * DailyRate;
            }
            else if (totalDays < 30 && WeeklyRate > 0)
            {
                int weeks = (int)Math.Ceiling(totalDays / 7.0);
                return weeks * WeeklyRate;
            }
            else if (MonthlyRate > 0)
            {
                int months = (int)Math.Ceiling(totalDays / 30.0);
                return months * MonthlyRate;
            }
            else
            {
                return (decimal)Math.Ceiling(totalDays) * DailyRate;
            }
        }
    }
}
