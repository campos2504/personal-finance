using Domain.Interfaces.ICategory;
using Entities.Entites;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CategoryRepository : GenericsRepository<Category>, ICategory
    {
        public Task<IList<Category>> UserCategoriesList(string email)
        {
            throw new NotImplementedException();
        }
    }
}
