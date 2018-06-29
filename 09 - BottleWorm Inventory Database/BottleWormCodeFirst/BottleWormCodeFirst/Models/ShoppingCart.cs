using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleWormCodeFirst.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public Customer CartCustomer { get; set; }
        public ICollection<Inventory> Cart { get; set; }
    }
}
