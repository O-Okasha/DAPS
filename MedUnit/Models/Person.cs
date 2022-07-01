using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models

{
    public class Person
    {
        public Person(string fname, int id, string lname, int age, string ssn, Gender gender, string address)
        {
            Fname = fname ?? throw new ArgumentNullException(nameof(fname));
            Id = id;
            Lname = lname ?? throw new ArgumentNullException(nameof(lname));
            Age = age;
            SSN = ssn ?? throw new ArgumentNullException(nameof(ssn));
            Gender = gender;
            Address = address;
        }

        public string Fname { get; set; }
        public int Id { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
    }
}