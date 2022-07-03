using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAPS.Models
{
    internal class FHIRPatient
    {
        public string resourceType = "Patient";
        public HumanName name { get; set; }
        public List<Dictionary<string, string>> telecom { get; set; }
        public List<Dictionary<string, string>> address { get; set; }
        public string gender { get; set; }
        public string id { get; set; }
        public string age { get; set; }

    }
}
