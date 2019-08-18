using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webstore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Subcategory> Subcategories { get; set; }

        public Category()
        {
            Subcategories = new List<Subcategory>();
        }
    }
}
