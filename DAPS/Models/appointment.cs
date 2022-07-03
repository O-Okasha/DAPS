using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAPS.Models
{
    public class Appointment
    {
        public Appointment(string id, string patientID, DateTime dateTime, string textid, PatientModel patient)
        {
            this.Patient = patient;
            Id = id ?? throw new ArgumentNullException(nameof(id));
            this.dateTime = dateTime;
            PatientId = patientID;
            Status = false;
            textID = textid ?? throw new ArgumentNullException(nameof(textid));
        }
        [BsonId]
        public string Id { get; set; }
        public string textID { get; set; }
        public string PatientId { get; set; }
        public PatientModel Patient { get; set; }
        public DateTime dateTime { get; set; }
        public bool Status { get; set; }

        public void AddPatient(PatientModel p)
        {
            this.Patient = p;
        }
    }
}
