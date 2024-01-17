using Domain.Interfaces.IFinancialSystemUser;
using Entities.Entites;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class FinancialSystemUserRepository : GenericsRepository<FinancialSystemUser>, IFinancialSystemUser
    {
        public Task<FinancialSystemUser> GetSystemUsersByEmail(string userEmail)
        {
            throw new NotImplementedException();
        }

        public Task RemoveUsers(List<FinancialSystemUser> users)
        {
            throw new NotImplementedException();
        }

        public Task<IList<FinancialSystemUser>> SystemUsersList(int FinancailSystemId)
        {
            throw new NotImplementedException();
        }
    }
}
