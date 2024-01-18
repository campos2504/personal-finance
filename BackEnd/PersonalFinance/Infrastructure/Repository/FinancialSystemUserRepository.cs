using Domain.Interfaces.IFinancialSystemUser;
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
    public class FinancialSystemUserRepository : GenericsRepository<FinancialSystemUser>, IFinancialSystemUser
    {
        private readonly DbContextOptions<BaseContext> _OptionsBuider;
        public FinancialSystemUserRepository()
        {
            _OptionsBuider = new DbContextOptions<BaseContext>();
        }
        public async Task<FinancialSystemUser> GetSystemUsersByEmail(string userEmail)
        {
            using var data = new BaseContext(_OptionsBuider);

            return await data.FinancialSystemUser
                .FirstOrDefaultAsync(x => x.UserEmail.Equals(userEmail));
        }

        public async Task RemoveUsers(List<FinancialSystemUser> users)
        {
            using var data = new BaseContext(_OptionsBuider);
            data.FinancialSystemUser.RemoveRange(users);
            await data.SaveChangesAsync();
        }

        public async Task<IList<FinancialSystemUser>> SystemUsersList(int financailSystemId)
        {
            using var data = new BaseContext(_OptionsBuider);
            return await data.FinancialSystemUser
                .Where(x => x.FinacialSystemId == financailSystemId)
                .AsNoTracking().ToListAsync();
        }
    }
}
