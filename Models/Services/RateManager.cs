using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalApp.Data.Repositories;
using RentalApp.Models.Core;


namespace RentalApp.Models.Services
{
    public class RateManager
    {
        private CategoryRespository _categoryRepository;

        public RateManager()
        {
            _categoryRepository = new CategoryRespository();
        }

        public void UpdateRate(int categoryId, decimal newDailyRate, decimal newWeeklyRate, decimal newMonthlyRate)
        {
            

            var category = _categoryRepository.GetById(categoryId);

            if (category == null)
            {
                throw new ArgumentException("Category not found.");
            }
            

            if (category.DailyRate != newDailyRate || category.WeeklyRate != newWeeklyRate || category.MonthlyRate != newMonthlyRate)
            {
                _categoryRepository.UpdateRate(categoryId, newDailyRate, newWeeklyRate, newMonthlyRate);
            }else
            {
                return;
            }
        }

        public void AddCategory(VehicleCategory category)
        {
            if (category.CategoryName == null)
            {
                throw new ArgumentException("Category name cannot be null.");
            }

            if (category.DailyRate <= 0 && category.WeeklyRate <= 0 && category.MonthlyRate <= 0)
            {
                throw new ArgumentException("At least one rate (Daily, Weekly, or Monthly) must be greater than zero.");
            }
            _categoryRepository.Add(category);
        }

        public List<VehicleCategory> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public List<VehicleCategory> GetCategoriesByCategoryName(string categoryName)
        {
            return _categoryRepository.GetAll().Where(c => c.CategoryName == categoryName).ToList();
        }    
        public List<VehicleCategory> GetCategoriesByDailyRate(decimal dailyRate)
        {
            return _categoryRepository.GetAll().Where(c => c.DailyRate == dailyRate).ToList();
        }    public List<VehicleCategory> GetCategoriesByWeeklyRate(decimal weeklyRate)
        {
            return _categoryRepository.GetAll().Where(c => c.WeeklyRate == weeklyRate).ToList();
        }    public List<VehicleCategory> GetCategoriesByMonthlyRate(decimal monthlyRate)
        {
            return _categoryRepository.GetAll().Where(c => c.MonthlyRate == monthlyRate).ToList();
        }
    }
}
