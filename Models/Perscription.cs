using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Perscription
    {
        List<Medicine> perscription;

        public Perscription(List<Medicine> perscription, Patient patient, Doctor doctor, string date)
        {
            this.perscription = perscription ?? throw new ArgumentNullException(nameof(perscription));
            this.patient = patient ?? throw new ArgumentNullException(nameof(patient));
            this.doctor = doctor ?? throw new ArgumentNullException(nameof(doctor));
            this.date = date ?? throw new ArgumentNullException(nameof(date));
        }

        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        public string date { get; set; }
    }
}
