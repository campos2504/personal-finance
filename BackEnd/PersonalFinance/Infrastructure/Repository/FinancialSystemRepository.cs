using Domain.Interfaces.IFinancialSystem;
using Entities.Entites;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infrastructure.Repository
{
    public class FinancialSystemRepository : GenericsRepository<FinancialSystem>, IFinancialSystem
    {
        private readonly DbContextOptions<BaseContext> _OptionsBuider;
        public FinancialSystemRepository()
        {
            _OptionsBuider = new DbContextOptions<BaseContext>();
        }
        public async Task<IList<FinancialSystem>> UserSystemList(string userEmail)
        {
            using var data = new BaseContext(_OptionsBuider);

            return await
                (from fs in data.FinancialSystem
                 join fsu in data.FinancialSystemUser
                 on fs.Id equals fsu.FinacialSystemId
                 where fsu.UserEmail.Equals(userEmail)
                 select fs).AsNoTracking().ToListAsync();
        }
    }
}
