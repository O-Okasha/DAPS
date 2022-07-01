using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Medicine
    {
        public Medicine(string commercialName, string activeSubstance, float price, string id, string _class)
        {
            CommercialName = commercialName ?? throw new ArgumentNullException(nameof(commercialName));
            ActiveSubstance = activeSubstance ?? throw new ArgumentNullException(nameof(activeSubstance));
            this.price = price;
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Class = _class;
        }
        public string Class { get; set; }
        public string CommercialName { get; set; }
        public string ActiveSubstance { get; set; }
        public float price { get; set; }
        public string Id { get; set; }

    }
}
