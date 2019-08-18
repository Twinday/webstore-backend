using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webstore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Status { get; set; } // 0 - в корзине, 1 - оплачен

        public virtual List<Item> Items { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
