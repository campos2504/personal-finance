using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites
{
    public class FinancialSystemUser
    {
        public int Id { get; set; }
        public  string UserEmail { get; set; }
        public bool Admin { get; set; }
        public bool CurrentSystem { get; set; }

        [ForeignKey("FinacialSystem")]
        [Column(Order = 1)]
        public int FinacialSystemId { get; set; }
        public virtual FinancialSystem? FinancialSystem { get; set; }
    }
}
