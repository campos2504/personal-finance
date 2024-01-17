using Domain.Interfaces.IFinancialSystem;
using Entities.Entites;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class FinancialSystemRepository : GenericsRepository<FinancialSystem>, IFinancialSystem
    {
        public Task<IList<FinancialSystem>> UserSystemList(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
