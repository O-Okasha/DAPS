using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PerscribedInvestigation : Investigation
    {
        public PerscribedInvestigation(string report, string patientID, string doctorID, Investigation investigation) : base(investigation)
        {
            Report = report;
            PatientID = patientID;
            DoctorID = doctorID;
        }

        public string Report { get; set; }
        public string PatientID { get; set; }
        public string DoctorID { get; set; }

    }
}
