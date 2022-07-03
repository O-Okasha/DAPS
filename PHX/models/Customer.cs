using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHX.models
{
    public class Customer
    {
        public Customer(string _ID, string _Name, string _Email, string _Phone)
        {
            ID = _ID;
            Name = _Name;
            Email = _Email;
            Phone = _Phone;
        }

        [BsonId]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
