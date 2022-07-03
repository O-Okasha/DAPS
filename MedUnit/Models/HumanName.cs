using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class HumanName
    {
        public string use = "official";
        public string family { get; set; }
        public List<string> given = new List<string>();
    }
}
