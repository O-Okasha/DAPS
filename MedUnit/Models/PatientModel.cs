using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models

{
    public class PatientModel: Person
    {
        public PatientModel(string fname, string id, string lname, int age, string ssn, Gender gender, string address) : base(fname, id, lname, age, ssn, gender, address)
        {
            Record = new Record();
        }

        public Record Record { get; set; }



    }
}
