using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class VisitDetails
    {
        public string complaints { get; set; }
        public string Diagnosis { get; set; }
        public string ProblemDiscription { get; set; }
        public string ProblemID { get; set; }



        public VisitDetails()
        {
           
        }
        public void AddComplaint(string complaint)
        {
            complaints = complaint.Trim();
        }

        public void AddDiagnosis(string diganosis)
        {
            Diagnosis = diganosis.Trim();
        }
        public void AddProblemDisc(string problemdisc)
        {
            ProblemDiscription = problemdisc.Trim();
        }
        public void AddProblem(string problem)
        {
            ProblemID = problem;
        }




    }

}
