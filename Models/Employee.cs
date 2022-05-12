using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Employee : Person
    {
        public Employee(string fname, int id, string lname, int age, string ssn, Gender gender, Department department, string address) : base(fname, id, lname, age, ssn, gender, address)
        {
            Department = department;
        }

        public Department Department { get; set; }


    }
}
