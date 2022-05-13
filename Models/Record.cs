using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Record
    {

        public int Id { get; set; }
        public List<Problem> Problems { get; set; }
        public List<Service> Services { get; set; }
        public List<PerscribedInvestigation> PerscribedInvestigations { get; set; }
        public List<Visit> Visits { get; set; }
        public string FamilyHistory { get; set; }
        public string PersonalHistory { get; set; }


    }
}
