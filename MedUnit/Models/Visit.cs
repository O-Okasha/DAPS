using MongoDB.Bson.Serialization.Attributes;
using System;

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
        public PatientModel Patient { get; set; }
        public DateTime dateTime { get; set; }
        public string notes { get; set; }
        public VisitDetails VisitDetails { get; set; }
        public bool Status { get; set; }
        public VisitShort Shorten()
        {
            VisitShort visit = new VisitShort(Id, PatientId, dateTime)
            {
                notes = notes,
                VisitDetails = VisitDetails,
                Status = Status
            };
            return visit;
        }
    }
}
