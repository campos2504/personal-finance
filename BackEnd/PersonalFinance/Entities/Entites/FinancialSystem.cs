using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites
{
    [Table("FinancialSystem")]
    public class FinancialSystem : Base
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int ClosingDay { get; set; }
        public bool GenerateExpenseCopy { get; set; }
        public int CopyMonth { get; set; }
        public int CopyYear { get; set; }

    }
}
