using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHX.models
{
    public class Store_Settings
    {
        [BsonId]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public string Email { get; set; }
        public string Storeweb { get; set; }
        public string StorePhone { get; set; }
        public string Address { get; set; }

    }
}
