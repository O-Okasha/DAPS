
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAPS.Models
{
    public class Bill
    {
        [Bson]
        public string ID { get; set; }
        public string PatientSSD { get; set; }
        public List<Service> services;
        public int total;
        public bool state;

        public Bill()
        {
            ID = Guid.NewGuid().ToString();
            services = new List<Service>();
            state = false;
        }
        private void CalculateTotal()
        {
            total = 0;
            foreach (Service service in services)
            {
                total += service.price;
            }
        }
        public void AddService(Service serv) {
            services.Add(serv);
            CalculateTotal();
        }


        public void AddServices(List<Service> ser) { 
            services = ser; 
            CalculateTotal();
        }


    }
}
