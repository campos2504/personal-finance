using Domain.Interfaces.ICategory;
using Domain.Interfaces.IExpense;
using Domain.Interfaces.IServices;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ExpenseService : IExpenseService
    {

        private readonly IExpense _iExpense;
        public ExpenseService(IExpense iExpense)
        {
            _iExpense = iExpense;
        }

        public async Task AddExpense(Expense expense)
        {
            var date = DateTime.UtcNow;
            expense.CreateDate = date;
            expense.Year = date.Year; 
            expense.Month = date.Month;

            var valid = expense.StringPropertieValidation(expense.Name, "Name");
            if (valid)
                await _iExpense.Add(expense);
        }

        public async Task UpdateExpense(Expense expense)
        {
            var date = DateTime.UtcNow;
            expense.UpdateDate = date;

            if (expense.Paid)
                expense.PayDay = date;

            var valid = expense.StringPropertieValidation(expense.Name, "Nome");
            if (valid)
                await _iExpense.Update(expense);
        }
    }
}
