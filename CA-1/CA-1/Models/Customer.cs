using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_1.Models
{
    public class Customer
    {
        [Key]

        public int CustomerNumber { get; set; }
        public string Name { get; set; }

        public long ContactNumber { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
    }
}
