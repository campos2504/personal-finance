using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites
{
    [Table("Expense")]
    public class Expense: Base
    {
        public decimal Value { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public ExpenseTypeEnum ExpenseType { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime PayDay { get; set; }
        public DateTime DueDate { get; set; }
        public bool Paid { get; set; }
        public bool Delayed { get; set; }
        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
