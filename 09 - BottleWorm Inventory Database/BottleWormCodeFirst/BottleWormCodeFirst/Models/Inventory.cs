using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottleWormCodeFirst.Enums;

namespace BottleWormCodeFirst.Models
{
    public class Inventory : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public InventoryType InventoryType { get; set; }

        public InventoryType ConvertStringToItemType(string inventoryType)
        {
            if (inventoryType.ToUpper() == "BEER")
            {
                return InventoryType.Beer;
            }
            else if (inventoryType.ToUpper() == "LIQUOR")
            {
                return InventoryType.Liquor;
            }
            else if (inventoryType.ToUpper() == "WINE")
            {
                return InventoryType.Wine;
            }

            return InventoryType.Misc;
        }
    }
}
