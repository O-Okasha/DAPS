using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class Record
    {

        public int Id { get; set; }
        public List<Problem> Problems { get; set; }
        public List<Service> Services { get; set; }
        public List<PerscribedInvestigation> PerscribedInvestigations { get; set; }
        public List<Visit> Visits { get; set; }
        public string FamilyHistory { get; set; }
        public string PersonalHistory { get; set; }

        public Record()
        {
            Problems = new List<Problem>();
            Services = new List<Service>();
            PerscribedInvestigations = new List<PerscribedInvestigation>();
            Visits = new List<Visit>();
        }
        public void AddProblem(Problem problem)
        {
            Problems.Add(problem);

        }
        public void AddService(Service service)
        {
            Services.Add(service);
        }
        public void AddInvestigation(PerscribedInvestigation perscribedInvestigation)
        {
            PerscribedInvestigations.Add(perscribedInvestigation);
        }
        public void AddVisits(Visit visit)
        {
            Visits.Add(visit);
        }
        public void AddFamilyHistory(string FamHistory)
        {
            FamilyHistory += '\n' + FamHistory;
        }
        public void AddHistory(string history)
        {
            PersonalHistory += '\n' + history;
        }
    }
}
