using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWorm.core.Models
{
    public abstract class EmployeeBase
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public decimal HoursWorked { get; set; }
    }
}
