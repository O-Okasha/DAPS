using System;
using System.Collections.Generic;


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
        public static Problem ActiveProblem;
        public static TreatmentPlan ActivePlan;
        public static List<Visit> visits = new List<Visit>();
        static string _id = Guid.NewGuid().ToString();
        static Patient patient1 = new Patient("Omar", _id, "Khaled", 23, "asssfsfdsf", Gender.Male, "Degla");
        static Visit test = new Visit(_id, _id, DateTime.Now);
        
        public static void refresh()
        {
            test.Patient = patient1;
            visits.Add(test);
        }
        public static void ChangeProblem(Problem n)
        {
            if (ActiveProblem != null)
            {
                ActiveProblem.TreatmentPlan = ActivePlan;
                for (int i = 0; i < patient.Record.Problems.Count; i++)
                {
                    if (patient.Record.Problems[i].Id == ActiveProblem.Id)
                    {
                        patient.Record.Problems[i] = ActiveProblem;
                    }
                }
            }
            ActiveProblem = n;
            ActivePlan = ActiveProblem.TreatmentPlan;
        }
        public static void SaveAll()
        {
            ActiveProblem.TreatmentPlan = ActivePlan;
            for (int i = 0; i < patient.Record.Problems.Count; i++)
            {
                if (patient.Record.Problems[i].Id == ActiveProblem.Id)
                {
                    patient.Record.Problems[i] = ActiveProblem;
                }
            }
        }


    }
}
