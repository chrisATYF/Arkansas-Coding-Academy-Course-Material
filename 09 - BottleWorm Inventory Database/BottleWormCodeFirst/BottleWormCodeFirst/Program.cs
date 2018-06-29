using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottleWormCodeFirst.Models;
using BottleWormCodeFirst.Views;

namespace BottleWormCodeFirst
{
    class Program
    {
        public static UserViews _userView = new UserViews();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To BottleWorm");

            var menuText = "Main Menu";
            var isRunning = true;
            while (isRunning)
            {
                _userView.MainMenu(menuText);
                var input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "B":
                        InventoryViewer();
                        break;

                    case "L":
                        EmployeeScreen();
                        break;

                    case "N":
                        HireScreen();
                        break;

                    case "Q":
                        Console.WriteLine("Goodbye");
                        isRunning = false;
                        break;

                    default:
                        break;
                }
            }
        }

        static void HireScreen()
        {
            var menuText = "New Employee";
            var isRunning = true;
            while (isRunning)
            {
                _userView.HireEmployee(menuText);
                var input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "N":
                        _userView.AddNewHire();
                        break;

                    case "BACK":
                        isRunning = false;
                        break;

                    default:
                        break;
                }
            }
        }

        static void EmployeeScreen()
        {
            var menuText = "Employee Menu";
            var isRunning = true;
            while (isRunning)
            {
                _userView.EmployeeScreen(menuText);
                var input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "A":
                        _userView.AddItem();
                        break;

                    case "D":
                        break;

                    case "I":
                        break;

                    case "R":
                        break;

                    case "BACK":
                        isRunning = false;
                        break;

                    default:
                        break;
                }
            }
        }

        static void InventoryViewer()
        {
            var menuText = "Inventory Menu";
            var isRunning = true;
            while (isRunning)
            {
                _userView.InventoryMenu(menuText);
                var input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "B":
                        BeerMenu();
                        break;

                    case "L":
                        LiquorMenu();
                        break;

                    case "W":
                        WineMenu();
                        break;

                    case "BACK":
                        isRunning = false;
                        break;

                    default:
                        break;
                }
            }
        }

        static void BeerMenu()
        {
            var menuText = "Beer";
            var isRunning = true;
            while (isRunning)
            {
                _userView.BeerMenu(menuText);
                var input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "CHECKOUT":
                        CheckOutMenu();
                        break;

                    case "BACK":
                        isRunning = false;
                        break;

                    default:
                        break;
                }
            }
        }

        static void LiquorMenu()
        {
            var menuText = "Liquor";
            var isRunning = true;
            while (isRunning)
            {
                _userView.LiquorMenu(menuText);
                var input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "CHECKOUT":
                        CheckOutMenu();
                        break;

                    case "BACK":
                        isRunning = false;
                        break;

                    default:
                        break;
                }
            }
        }

        static void WineMenu()
        {
            var menuText = "Wine";
            var isRunning = true;
            while (isRunning)
            {
                _userView.WineMenu(menuText);
                var input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "CHECKOUT":
                        CheckOutMenu();
                        break;

                    case "BACK":
                        isRunning = false;
                        break;

                    default:
                        break;
                }
            }
        }

        static void CheckOutMenu()
        {
            var menuText = "Checkout";
            var isRunning = true;
            while (isRunning)
            {
                _userView.CheckOutMenu(menuText);
                var input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "C":
                        break;

                    case "D":
                        break;

                    case "BACK":
                        isRunning = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
