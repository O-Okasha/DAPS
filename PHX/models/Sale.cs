using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHX.models
{
    public class Sale{
        public Sale(string _ID, string _Name, string _SellingPrice, float _Discount, float _GrandTotal)
        {
            ID = _ID;
            Name = _Name;
            SellingPrice = _SellingPrice;
            Discount = _Discount;   
            GrandTotal = _GrandTotal;
        }

        [BsonId]
        public string ID { get; set; }
        public string Name { get; set; }
        public string SellingPrice { get; set; }
        public float Discount { get; set; }
        public float GrandTotal { get; set; }



    }
}
