using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class PrescribedMedicine
    {
        public Medicine Medicine { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Dose { get; set; }

        public PrescribedMedicine(Medicine medicine, string startDate, string endDate, string dose)
        {
            Medicine = medicine;
            StartDate = startDate;
            EndDate = endDate;
            Dose = dose;
        }

     }
}
