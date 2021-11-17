using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_1.Models
{
    public class Item
    {
        [Key]
        public int ItemNumber { get; set; }
        public string Name { get; set; }

        public int Itemvalue { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
    }
}
