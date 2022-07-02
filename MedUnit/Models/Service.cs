using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class Service
    {
        public Service(string id, string name, string description, int price, string type)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            this.price = price;
            Type = type;
        }
        public Service(Service service)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }
            Id = service.Id;
            Name = service.Name;
            Description = service.Description;
        }
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
    }
}
