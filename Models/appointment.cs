using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class appointment
    {
        public string id { get; set; }
        public bool status { get; set; }
        public DateTime time { get; set; }
        public string patient_id { get; set; }


        public appointment(string id, bool status, DateTime time, string patient_id) 
        {
            this.id = id;
            this.status = status;
            this.time = time;
            this.patient_id = patient_id;
        }

        

    }

}
