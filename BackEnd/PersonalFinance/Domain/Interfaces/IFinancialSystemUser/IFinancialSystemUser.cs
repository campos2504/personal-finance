using Domain.Interfaces.Generics;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IFinancialSystemUser
{
    public interface IFinancialSystemUser : IGenerics<FinancialSystemUser>
    {

        Task<IList<FinancialSystemUser>> SystemUsersList(int FinancailSystemId);

        Task RemoveUsers(List<FinancialSystemUser> users);

        Task<FinancialSystemUser> GetSystemUsersByEmail(string userEmail);

    }
}
