using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class Visit
    {
        public Visit(string id, Doctor doctor, Patient patient, DateTime dateTime)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Doctor = doctor ?? throw new ArgumentNullException(nameof(doctor));
            Patient = patient ?? throw new ArgumentNullException(nameof(patient));
            this.dateTime = dateTime;
        }

        public string Id { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime dateTime { get; set; }
        public VisitDetails VisitDetails { get; set; }
        public bool Status { get; set; }
    }
}
