using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Service
    {
        public Service(int id, string name, string description, int price)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
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
            Description = service.Description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
    }
}
