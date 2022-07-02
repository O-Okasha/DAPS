using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class Visit
    {
        public Visit(string id, string patientID, DateTime dateTime)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            this.dateTime = dateTime;
            PatientId = patientID;
            Status = false;
        }
        [BsonId]
        public string Id { get; set; }
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime dateTime { get; set; }
        public string notes { get; set; }
        public VisitDetails VisitDetails { get; set; }
        public bool Status { get; set; }
    }
}
