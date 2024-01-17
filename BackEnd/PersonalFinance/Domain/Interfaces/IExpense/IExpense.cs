using Domain.Interfaces.Generics;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IExpense
{
    public interface IExpense :IGenerics<Expense>
    {
        Task<IList<Expense>> UserExpensesList(string userEmail);

        Task<IList<Expense>> NotPaidLastMonthUserExpensesList(string userEmail);

    }
}
