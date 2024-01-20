using Domain.Interfaces.IFinancialSystem;
using Domain.Interfaces.IFinancialSystemUser;
using Domain.Interfaces.IServices;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FinancialSystemUserService : IFinancialSystemUserService
    {
        private readonly IFinancialSystemUser _iFinancialSystemUser;

        public FinancialSystemUserService(IFinancialSystemUser iFinancialSystemUser)
        {
            _iFinancialSystemUser = iFinancialSystemUser;
        }
        public async Task SingUpUserOnFiancialSytem(FinancialSystemUser user)
        {
            await _iFinancialSystemUser.Update(user);        
        }
    }
}
