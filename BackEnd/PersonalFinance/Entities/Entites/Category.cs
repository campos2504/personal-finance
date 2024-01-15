
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entites
{
    [Table("Category")]
    public class Category : Base
    {
        [ForeignKey("Financialsystem")]
        [Column(Order = 1)]
        public int SystemId { get; set; }
        public virtual FinancialSystem? FinancialSystem { get; set; }

    }
}
