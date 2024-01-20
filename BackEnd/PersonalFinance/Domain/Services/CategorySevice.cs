using Domain.Interfaces.ICategory;
using Domain.Interfaces.IServices;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CategorySevice : ICategorySevice
    {
        private readonly ICategory _iCategory;
        public CategorySevice(ICategory iCategory)
        {
            _iCategory = iCategory;
        }
        public async Task AddCategiory(Category category)
        {
            var valid = category.StringPropertieValidation(category.Name, "Name");
            if(valid)
                await _iCategory.Add(category);

        }

        public async Task UpdateCategiory(Category category)
        {
            var valid = category.StringPropertieValidation(category.Name, "Name");
            if (valid)
                await _iCategory.Update(category);
        }
    }
}
