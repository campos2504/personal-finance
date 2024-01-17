using Domain.Interfaces.IExpense;
using Entities.Entites;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ExpenseRepository : GenericsRepository<Expense>, IExpense
    {
        public Task<IList<Expense>> NotPaidLastMonthUserExpensesList(string userEmail)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Expense>> UserExpensesList(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
