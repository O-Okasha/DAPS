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
        public bool Allergies { get; set; }
        public bool Cancer { get; set; }
        public bool Bloodthinner { get; set; }  
        public List<Problem> Problems { get; set; }
        public List<VisitShort> Visits { get; set; }
        public List<Perscription> Perscriptions { get; set; }
        public string FamilyHistory { get; set; }
        public string PersonalHistory { get; set; }
        

        public Record()
        {
            Problems = new List<Problem>();
            Perscriptions = new List<Perscription>();
            Visits = new List<VisitShort>();
            Allergies = false;
            Cancer = false;
            Bloodthinner = false;
        }
        public void AddProblem(Problem problem)
        {
            Problems.Add(problem);

        }
        public void AddVisits(VisitShort visit)
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
        public void AddPrescription(Perscription perscription)
        {
            Perscriptions.Add(perscription);
        }
    }
}
