using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class TreatmentPlan
    {
        public string TreatmentPlanId { get; set; } 
        public string TreatmentPlanName { get; set; }
        public List<Service> services { get; set; }
        public List<Service> CompletedServices { get; set; }
        public List<Service> WaitingServices { get; set; }

        public TreatmentPlan(string id, string name)
        {
            TreatmentPlanId = id;
            TreatmentPlanName = name;
        }
        public void AddServices(List<Service> service)
        {
            services = service;
            WaitingServices = service;
        }
        public void CompleteService(Service service)
        {
            CompletedServices.Add(service);
            WaitingServices.Remove(service);
        }
    }
}
