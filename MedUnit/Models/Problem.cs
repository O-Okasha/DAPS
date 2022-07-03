using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class Problem
    {
        public Problem(string problemDiagnosis)
        {
            ProblemDiagnosis = problemDiagnosis ?? throw new ArgumentNullException(nameof(problemDiagnosis));
        }
        public string Id = Guid.NewGuid().ToString();
        public string priority { get; set; }
        public string ProblemDiagnosis { get; set; }
        public string ProblemNotes { get; set; }
        public string ProblemLocation { get; set; }
        public TreatmentPlan TreatmentPlan { get; set; }


    }
}
