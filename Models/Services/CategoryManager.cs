using System;
using System.Collections.Generic;
using RentalApp.Data.Repositories;
using RentalApp.Models.Core;

namespace RentalApp.Models.Services
{
    public class CategoryManager
    {
        private CategoryRepository _categoryRepository;

        public CategoryManager()
        {
            _categoryRepository = new CategoryRepository();
        }

        public List<VehicleCategory> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public VehicleCategory GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }
    }
}

