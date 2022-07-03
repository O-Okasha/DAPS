using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHX.models
{
    public class Purchase
    {
        public Purchase(string _ID, float _Discount, string _Category, float _BuyingPrice, string _BatchNumber, string _Quantity, string _Date, string _Payment, string _Status, float _GrandTotal )
        {
            ID = _ID;
            Discount = _Discount;
            Category = _Category;
            BuyingPrice = _BuyingPrice;
            BatchNumber = _BatchNumber;
            Quantity = _Quantity;
            Date = _Date;
            Payment = _Payment;
            Status = _Status;
            GrandTotal = _GrandTotal;
        }

        [BsonId]
        public string ID { get; set; }
        public float Discount  { get; set; }
        public string Category { get; set; }
        public float BuyingPrice { get; set; }
        public string BatchNumber { get; set; }
        public string Quantity { get; set; }
        public string Date { get; set; }
        public string Payment { get; set; }
        public string Status { get; set; }
        public float GrandTotal { get; set; }
    }
}
