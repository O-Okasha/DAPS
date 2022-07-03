using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHX.models
{
    public class Category{
        public Category(string _ID, string _Name, string _Description)
        {
            ID = _ID;
            Name = _Name;
            Description = _Description;
        }

        [BsonId]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
