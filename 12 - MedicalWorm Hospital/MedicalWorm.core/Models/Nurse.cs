using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalWorm.core.Enums;
using MedicalWorm.core.Interfaces;

namespace MedicalWorm.core.Models
{
    public class Nurse : EmployeeBase, IEmployee
    {
        public bool IsRegisteredNurse { get; set; }
        public NursingCertification Certifications { get; set; }

        public IEnumerable<int> FloorsWorked { get; set; }

        public decimal CalculatePay()
        {
            return HoursWorked * 150;
        }

        public string printBadge()
        {
            return "";
        }
    }
}
