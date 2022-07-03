using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class TreatmentPlan
    {
        [BsonId]
        public string TreatmentPlanId { get; set; } 
        public string TreatmentPlanName { get; set; }
        public List<Service> services { get; set; }
        public List<Service> CompletedServices { get; set; }
        public List<Service> WaitingServices { get; set; }

        public TreatmentPlan(string id, string name)
        {
            TreatmentPlanId = id;
            TreatmentPlanName = name;
            services = new List<Service>();
            CompletedServices = new List<Service>();    
            WaitingServices = new List<Service>();
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
            for (int i = 0; i < WaitingServices.Count; i++)
            {
                if (WaitingServices[i].Id == service.Id)
                {
                    WaitingServices.RemoveAt(i);
                }
            }
        }
        public void AddService(Service service)
        {
            WaitingServices.Add(service);
            services.Add(service);
        }
    }
}
