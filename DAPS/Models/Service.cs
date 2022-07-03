using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAPS.Models
{
    public class Service
    {
        public Service(string id, string name, int price)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            this.price = price;

        }
        public Service(Service service)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }
            Id = service.Id;
            Name = service.Name;
        }
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
    }
}
