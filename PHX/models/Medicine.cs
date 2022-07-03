using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PHX.models
{
    
    public class Medicine
    {
        [BsonId]
        public string MedID{ get; set; }
        public string MedName{ get; set; }
        public string MedBatchNumber { get; set; }
        public float MedSellingPrice { get; set; }

        public string ShelfName { get; set; }

        public Medicine(string medID, string medName, string medBatchNumber, float medSellingPrice, string shelfName)
        {
            MedID = medID;
            MedName = medName;
            MedBatchNumber = medBatchNumber;
            MedSellingPrice = medSellingPrice;
            ShelfName = shelfName;
        }
    }
}
