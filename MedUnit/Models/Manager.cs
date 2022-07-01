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

    



    }
}
