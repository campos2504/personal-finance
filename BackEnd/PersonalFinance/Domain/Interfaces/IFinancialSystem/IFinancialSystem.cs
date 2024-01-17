using Domain.Interfaces.Generics;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IFinancialSystem
{
    public interface IFinancialSystem : IGenerics<FinancialSystem>
    {
        Task<IList<FinancialSystem>> UserSystemList(string userEmail);

    }
}
