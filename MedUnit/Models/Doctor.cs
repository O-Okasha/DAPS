using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class Doctor 
    {
        public Doctor() 
        {
            

        }
        [BsonId]
        public string email { get; set; }
        public string password { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string LicenseNumber { get; set; }

    }
}
