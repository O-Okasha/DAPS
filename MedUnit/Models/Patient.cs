using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models

{
    public class Patient: Person
    {
        public Patient(Record record, string fname, int id, string lname, int age, string ssn, Gender gender, string address) : base(fname, id, lname, age, ssn, gender, address)
        {
            Record = record;
        }

        public Record Record { get; set; }



    }
}
