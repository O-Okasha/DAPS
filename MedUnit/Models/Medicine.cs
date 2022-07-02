using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class Medicine
    {
        public Medicine(string activeSubstance, int price, string id, string _class)
        {
            ActiveSubstance = activeSubstance ?? throw new ArgumentNullException(nameof(activeSubstance));
            this.price = price;
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Class = _class;
        }
        public string Class { get; set; }
        public string ActiveSubstance { get; set; }
        public int price { get; set; }
        [BsonId]
        public string Id { get; set; }

    }
}
