using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class Bill
    {
        public string Id { get; set; }
        public string patientSSN { get; set; }
        public int total { get; set; }
        public string date { get; set; }
    }
}
