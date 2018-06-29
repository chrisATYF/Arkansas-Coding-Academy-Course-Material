using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalWorm.core.Enums;
using MedicalWorm.core.Interfaces;

namespace MedicalWorm.core.Models
{
    public class Doctor : EmployeeBase, IEmployee
    {
        public MedicalLicense LicenseObtained { get; set; }
        

        public decimal CalculatePay()
        {
            return HoursWorked * 180;
        }

        public string printBadge()
        {
            return $"{Name}, {LicenseObtained.MedicalLicenseFormatted2()} ({EmployeeId})";
        }
    }
}
