using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webstore.Models
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<Item> Items { get; set; }
    }
}
