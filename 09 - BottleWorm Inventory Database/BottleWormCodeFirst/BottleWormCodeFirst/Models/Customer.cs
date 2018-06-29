using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleWormCodeFirst.Models
{
    public class Customer : EntityBase
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        public ShoppingCart CustomerCart { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
        public ShoppingCart Cart { get; set; }
        public bool IsActive { get; set; }
    }
}
