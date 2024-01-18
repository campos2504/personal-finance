using Domain.Interfaces.ICategory;
using Entities.Entites;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CategoryRepository : GenericsRepository<Category>, ICategory
    {
        private readonly DbContextOptions<BaseContext> _OptionsBuider;
        public CategoryRepository()
        {
            _OptionsBuider = new DbContextOptions<BaseContext>();
        }
        public async Task<IList<Category>> UserCategoriesList(string email)
        {
            using (var data = new BaseContext(_OptionsBuider))
            {
                return await data.FinancialSystem.Join(
                    data.Category,
                    fs => fs.Id,
                    c=>c.FinancialSystemId,
                    (fs, c) => new {fs, c})
                    .Join(data.FinancialSystemUser,
                    fsc => fsc.fs.Id,
                    fsu => fsu.FinacialSystemId,
                    (fsc, fsu) => new { fsc.c, fsu }
                    ).Where(x => x.fsu.UserEmail.Equals(email))
                    .Select(x => x.c).AsNoTracking()
                    .ToListAsync();
                    

            }
        }
    }
}
