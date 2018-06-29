using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottleWormCodeFirst.Models;

namespace BottleWormCodeFirst.Views
{
    public class UserViews
    {
        public CustomerService customerService = new CustomerService();
        public Inventory Inventory = new Inventory();

        public void MainMenu(string menu)
        {
            PrintMenu($"{menu}");
            if (menu == "Main Menu")
            {
                Console.WriteLine("'B' Browse inventory");
                Console.WriteLine("'L' Employee login");
                Console.WriteLine("'N' New employee");
                Console.WriteLine("'Q' Quit");
            }
        }

        public void HireEmployee(string menu)
        {
            PrintMenu($"{menu}");
            if (menu == "New Employee")
            {
                Console.WriteLine("'N' To create new employee");
                Console.WriteLine("'BACK' To return to main menu");
            }
        }

        public void EmployeeScreen(string menu)
        {
            PrintMenu($"{menu}");
            if (menu == "Employee Menu")
            {
                Console.WriteLine("'A' To add new inventory items");
                Console.WriteLine("'D' Delete an item");
                Console.WriteLine("'I' Item lookup");
                Console.WriteLine("'R' Reorder items");
                Console.WriteLine("'BACK' Return to main menu");
            }
        }

        public void InventoryMenu(string menu)
        {
            PrintMenu($"{menu}");
            if (menu == "Inventory Menu")
            {
                Console.WriteLine("'B' for our selection of beer");
                Console.WriteLine("'L' for our selection of liquor");
                Console.WriteLine("'W' for our selection of wine");
                Console.WriteLine("'BACK' to return to main menu");
            }
        }

        public void AddItem()
        {
            Console.WriteLine("Enter item name");
            var itemName = Console.ReadLine();
            Console.WriteLine("Enter item price");
            var itemPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter BEER, WINE, or LIQUOR");
            var itemType = Console.ReadLine();
            var itemTypeToType = Inventory.ConvertStringToItemType(itemType);

            customerService.AddInventory(itemName, itemPrice, itemTypeToType);
        }

        public void AddNewHire()
        {
            Console.WriteLine("Enter employees name");
            var hireName = Console.ReadLine();
            Console.WriteLine("Enter 3-digit badge Id");
            var hireId = Convert.ToInt32(Console.ReadLine());

            customerService.AddEmployee(hireName, hireId);
        }

        public void BeerMenu(string menu)
        {
            PrintMenu($"{menu}");
            if (menu == "Beer")
            {
                Console.WriteLine("'CHECKOUT' to proceed to checkout");
                Console.WriteLine("'BACK' to return to main menu");
            }
        }

        public void LiquorMenu(string menu)
        {
            PrintMenu($"{menu}");
            if (menu == "Liquor")
            {
                Console.WriteLine("'CHECKOUT' to proceed to checkout");
                Console.WriteLine("'BACK' to return to main menu");
            }
        }

        public void WineMenu(string menu)
        {
            PrintMenu($"{menu}");
            if (menu == "Wine")
            {
                Console.WriteLine("'CHECKOUT' to proceed to checkout");
                Console.WriteLine("'BACK' to return to main menu");
            }
        }

        public void CheckOutMenu(string menu)
        {
            PrintMenu($"{menu}");
            if (menu == "Checkout")
            {
                Console.WriteLine("'C' for credit");
                Console.WriteLine("'D' for debit");
                Console.WriteLine("'BACK' to return to main menu");
            }
        }

        public void PrintMenu(string menuText)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(menuText);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
