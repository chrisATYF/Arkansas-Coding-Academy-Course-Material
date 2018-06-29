using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWorm.core.Interfaces
{
    public interface IEmployee
    {
        string printBadge();
        decimal CalculatePay();
    }
}
