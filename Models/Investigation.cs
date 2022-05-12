using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Investigation
    {
        public Investigation(Investigation investigation)
        {
            ID = investigation.ID;
            Name = investigation.Name;
            Description = investigation.Description;
            Price = investigation.Price;
        }

        public Investigation(string name, string description, int price, string ID)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Price = price;
            this.ID = ID;
        }
        public string ID { get;}
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
