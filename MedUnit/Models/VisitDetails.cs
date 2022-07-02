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
        public string notes { get; set; }
        public string Diagnosis { get; set; }
        public string ProblemDiscription { get; set; }
        public List<Investigation> investigations { get; set; }
        public List<Service> services { get; set; }
        public Problem Problem { get; set; }



        public VisitDetails()
        {
            investigations = new List<Investigation>();
            services = new List<Service>();
        }
        public void AddComplaint(string complaint)
        {
            complaints = complaint.Trim();
        }
        public void AddNotes(string note)
        {
            notes = note.Trim();
        }
        public void AddDiagnosis(string diganosis)
        {
            Diagnosis = diganosis.Trim();
        }
        public void AddProblemDisc(string problemdisc)
        {
            ProblemDiscription = problemdisc.Trim();
        }
        public void AddInvestigation(Investigation investigation)
        {
            investigations.Add(investigation);
        }
        public void AddService(Service service)
        {
            services.Add(service);  
        }
        public void AddProblem(Problem problem)
        {
            Problem = problem;
        }




    }

}
