using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWorm.core.Enums
{
    public static class EnumExtentions
    {
        public static string MedicalLicenseFormatted(MedicalLicense license)
        {
            if (license == MedicalLicense.DoctorOfMedicine)
            {
                return "M.D.";
            }

            return "D.O.";
        }

        public static string MedicalLicenseFormatted2(this MedicalLicense license, bool isUpperCase = true, bool usePeriods = true)
        {
            var abbrev = "";
            switch (license)
            {
                case MedicalLicense.DoctorOfOsteopathicMedicine:
                    abbrev = usePeriods
                        ? "D.O."
                        : "DO";
                    break;

                case MedicalLicense.DoctorOfMedicine:
                    abbrev = usePeriods
                        ? "M.D."
                        : "MD";
                    break;

                default:
                    abbrev = "";
                    break;
            }
            return isUpperCase
                ? abbrev.ToUpper()
                : abbrev.ToLower();
        }
    }
}
