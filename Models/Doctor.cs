using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Doctor: Employee
    {
        public Doctor(string fname, int id, string lname, int age, string ssn, Gender gender, Department department, string address, string ln) : base(fname, id, lname, age, ssn, gender, department, address)
        {
            LicenseNumber = ln;
        }

        public string LicenseNumber { get; set; }

    }
}
