using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHX.models
{
    public class StockList
    {
        public StockList(string _ID, string _Name, string _BatchNumber, string _TotalQuantity, string _Selling, float _BuyingPrice)
        {
            ID = _ID;
            Name = _Name;
            BatchNumber = _BatchNumber;
            TotalQuantity = _TotalQuantity;
            Selling = _Selling;
            BuyingPrice = _BuyingPrice;
        }

        [BsonId]
        public string ID { get; set; }
        public string Name { get; set; }
        public string BatchNumber { get; set; }
        public string TotalQuantity { get; set; }
        public string Selling { get; set; }
        public float BuyingPrice { get; set; }
    }
}
