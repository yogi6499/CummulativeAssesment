using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_1.Models
{
    public class Order
    {
        [Key]
        public int ordernumber { get; set; }
        public DateTime orderdate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Item Item { get; set; }
    }
}
