using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MedUnit.Models
{
    public static class Manager
    {
        public static Doctor doctor;
        public static Patient patient;
        public static List<Medicine> drugs;
        public static List<Service> services;
        public static List<TreatmentPlan> TreatmentPlans;
        public static DatabaseManager databaseManager = new DatabaseManager();
        public static List<Visit> visits = new List<Visit>();
        static string _id = Guid.NewGuid().ToString();
        static Patient patient1 = new Patient("Omar", _id, "Khaled", 23, "asssfsfdsf", Gender.Male, "Degla");
        static Visit test = new Visit(_id, _id, DateTime.Now);
        
        public static void refresh()
        {
            test.Patient = patient1;
            visits.Add(test);
        }



    }
}
