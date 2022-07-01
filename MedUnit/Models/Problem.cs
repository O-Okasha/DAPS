using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class Problem
    {
        public Problem(string problemDiagnosis, string problemName)
        {
            ProblemDiagnosis = problemDiagnosis ?? throw new ArgumentNullException(nameof(problemDiagnosis));
            ProblemName = problemName ?? throw new ArgumentNullException(nameof(problemName));
            
        }

        public string ProblemDiagnosis { get; set; }
        public string ProblemName { get; set; }
        public List<Action> Actions { get; set; }
        public TreatmentPlan TreatmentPlan { get; set; }


    }
}
