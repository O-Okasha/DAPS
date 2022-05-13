using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class VisitDetails
    {
        public string complaints { get; set; }
        public string notes { get; set; }
        public string Diagnosis { get; set; }
        public string subjective { get; set; }
        public List<Investigation> investigations { get; set; }
        public List<Service> services { get; set; }

    }
}
