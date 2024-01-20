using Domain.Interfaces.IExpense;
using Domain.Interfaces.IFinancialSystem;
using Domain.Interfaces.IServices;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FinancialSystemService : IFinancialSystemService
    {

        private readonly IFinancialSystem _iFinancialSystem;
        private static readonly int CLOSING_DAY = 1;
        public FinancialSystemService(IFinancialSystem iFinancialSystem)
        {
            _iFinancialSystem = iFinancialSystem;
        }
        public async Task AddFinancialSystem(FinancialSystem financialSystem)
        {
            var date = DateTime.Now;
            var valid = financialSystem.StringPropertieValidation(financialSystem.Name, "Name");

            if (valid)
            {
                financialSystem.ClosingDay = CLOSING_DAY;
                financialSystem.Year = date.Year;
                financialSystem.Month = date.Month;
                financialSystem.CopyYear = date.Year; 
                financialSystem.CopyMonth = date.Month;
                financialSystem.GenerateExpenseCopy = true;

                await _iFinancialSystem.Add(financialSystem);
            }
                
        }

        public async Task UpdateFinancialSystem(FinancialSystem financialSystem)
        {
            var valid = financialSystem.StringPropertieValidation(financialSystem.Name, "Name");

            if (valid)
            {
                financialSystem.ClosingDay = CLOSING_DAY;
                await _iFinancialSystem.Update(financialSystem);
            }
                
        }
    }
}
