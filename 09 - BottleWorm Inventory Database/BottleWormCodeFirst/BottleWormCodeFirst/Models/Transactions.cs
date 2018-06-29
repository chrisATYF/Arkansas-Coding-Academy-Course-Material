using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottleWormCodeFirst.Enums;

namespace BottleWormCodeFirst.Models
{
    public class Transactions : EntityBase
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public ICollection<AccountType> AccountTypes { get; set; }
    }
}
