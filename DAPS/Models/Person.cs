using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAPS.Models

{
    public class Person
    {
        public Person(string fname, string id, string lname, int age, string ssn, Gender gender, string address)
        {
            Fname = fname ?? throw new ArgumentNullException(nameof(fname));
            Id = id;
            Lname = lname ?? throw new ArgumentNullException(nameof(lname));
            Age = age;
            SSN = ssn ?? throw new ArgumentNullException(nameof(ssn));
            Gender = gender;
            Address = address;
            FullName = $"{Fname} {Lname}";
        }

        public string Fname { get; set; }
        [BsonId]
        public string Id { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
    }
}