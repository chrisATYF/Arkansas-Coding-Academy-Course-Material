using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BottleWormCodeFirst.Enums;

namespace BottleWormCodeFirst.Models
{
    public class CustomerService
    {
        public BottleContext _context = new BottleContext();

        public void AddInventory(string itemName, decimal itemPrice, InventoryType inventoryType)
        {
            var addedItem = new Inventory
            {
                Name = itemName,
                Price = itemPrice,
                InventoryType = inventoryType
            };
            _context.Inventories.Add(addedItem);
            _context.SaveChanges();
        }

        public void AddEmployee(string name, int badgeId)
        {
            var employee = new Employees
            {
                Name = name,
                BadgeId = badgeId
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}
