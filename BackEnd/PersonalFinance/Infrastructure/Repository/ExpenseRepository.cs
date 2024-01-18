using Domain.Interfaces.IExpense;
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
    public class ExpenseRepository : GenericsRepository<Expense>, IExpense
    {
        private readonly DbContextOptions<BaseContext> _OptionsBuider;
        public ExpenseRepository()
        {
            _OptionsBuider = new DbContextOptions<BaseContext>();
        }
        public async Task<IList<Expense>> NotPaidLastMonthUserExpensesList(string userEmail)
        {
            using (var data = new BaseContext(_OptionsBuider))
            {
                return await
                    (from fs in data.FinancialSystem
                     join c in data.Category
                     on fs.Id equals c.FinancialSystemId
                     join fsu in data.FinancialSystemUser
                     on fs.Id equals fsu.FinacialSystemId
                     join e in data.Expense
                     on c.Id equals e.CategoryId
                     where fsu.UserEmail.Equals(userEmail)
                     &&  e.Month < DateTime.Now.Month
                     && !e.Paid
                     select e).AsNoTracking().ToListAsync();


            }
        }

        public async Task<IList<Expense>> UserExpensesList(string userEmail)
        {
            using (var data = new BaseContext(_OptionsBuider))
            {
                return await
                    (from fs in data.FinancialSystem
                     join c in data.Category
                     on fs.Id equals c.FinancialSystemId
                     join fsu in data.FinancialSystemUser
                     on fs.Id equals fsu.FinacialSystemId
                     join e in data.Expense
                     on c.Id equals e.CategoryId
                     where fsu.UserEmail.Equals(userEmail)
                     && fs.Month == e.Month
                     && fs.Year == e.Year
                     select e).AsNoTracking().ToListAsync();


            }
        }
    }
}
