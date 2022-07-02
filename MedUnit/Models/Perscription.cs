using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models

{
    public class Perscription
    {
        public List<PrescribedMedicine> perscription { set; get; }

        public Perscription(string patient)
        {

            perscription = new List<PrescribedMedicine>();
            patientID = patient;
            Startdate = DateTime.Now.ToShortDateString();
        }

        public string patientID { get; set; }
        public string Startdate { get; set; }

        public void AddMedicine(PrescribedMedicine med)
        {
            if (med == null) { throw new ArgumentNullException(nameof(med)); }
            else
            {
                perscription.Add(med);
            }
        }
    }
}
