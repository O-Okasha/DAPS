using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Problem
    {
        public Problem(string problemDiagnosis, string problemName, List<Action> actions)
        {
            ProblemDiagnosis = problemDiagnosis ?? throw new ArgumentNullException(nameof(problemDiagnosis));
            ProblemName = problemName ?? throw new ArgumentNullException(nameof(problemName));
            Actions = actions ?? throw new ArgumentNullException(nameof(actions));
        }

        public string ProblemDiagnosis { get; set; }
        public string ProblemName { get; set; }
        public List<Action> Actions { get; set; }


    }
}
