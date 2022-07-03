using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAPS.Models

{
    public class Patient : Person
    {
        public Patient(string fname, string id, string lname, int age, string ssn, Gender gender, string address) : base(fname, id, lname, age, ssn, gender, address)
        {
        }


    }
}
