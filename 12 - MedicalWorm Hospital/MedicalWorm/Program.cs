using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalWorm.core.Enums;
using MedicalWorm.core.Interfaces;
using MedicalWorm.core.Models;

namespace MedicalWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            var nurse = new Nurse
            {
                EmployeeId = 124,
                Name = "Chris McDonald",
                FloorsWorked = new int[]
                {
                    1,2,3,4,5,6,7
                }
            };

            var nurse2 = new Nurse
            {
                EmployeeId = 124,
                Name = "Sarah Romero",
                FloorsWorked = new int[]
                {
                    1,3,4,6,7,9
                }
            };

            var nurses = new List<Nurse> { nurse, nurse2 };
            var theUpperFloors = nurses.Where(f => f.FloorsWorked != null).Select(n => n.Name).ToList();

            Console.WriteLine($"{nurse.printBadge()}");
            
            Console.ReadLine();
        }
    }
}
