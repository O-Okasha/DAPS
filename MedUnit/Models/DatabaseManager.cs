using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class DatabaseManager
    {
        public DatabaseManager() { }

        private const string ConnectionString = "mongodb://localhost:27017";
        private const string database = "clinic";
        private const string PatientsCollection = "patients";
        private const string DrugsCollection = "drugs";
        private const string ServicesCollection = "services";
        private const string TreatmentplansCollection = "treatment_plans";
        private const string AppointmentsCollection = "appointments";

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(database);
            return db.GetCollection<T>(collection);
        }
        public async Task<List<Medicine>> GetAllMedicines()
        {
            var drugsCollection = ConnectToMongo<Medicine>(DrugsCollection);
            var results = await drugsCollection.FindAsync(_ => true);
            return results.ToList();
        }
        public async Task<List<Service>> GetAllServices()
        {
            var drugsCollection = ConnectToMongo<Service>(ServicesCollection);
            var results = await drugsCollection.FindAsync(_ => true);
            return results.ToList();
        }
        public async Task<List<TreatmentPlan>> GetAllTreatmentplans()
        {
            var drugsCollection = ConnectToMongo<TreatmentPlan>(TreatmentplansCollection);
            var results = await drugsCollection.FindAsync(_ => true);
            return results.ToList();
        }
        public Task AddMedicine(Medicine med)
        {
            var drugCollection = ConnectToMongo<Medicine>(DrugsCollection);
            return drugCollection.InsertOneAsync(med);
        }
        public Task AddTreatmentplan(TreatmentPlan plan)
        {
            var treatmentplansCollection = ConnectToMongo<TreatmentPlan>(TreatmentplansCollection);
            return treatmentplansCollection.InsertOneAsync(plan);
        }
        public Task AddService(Service service)
        {
            var servicesCollection = ConnectToMongo<Service>(ServicesCollection);
            return servicesCollection.InsertOneAsync(service);
        }
        public Task AddPatient(PatientModel patient)
        {
            var patientsCollection = ConnectToMongo<PatientModel>(PatientsCollection);
            return patientsCollection.InsertOneAsync(patient);
        }
        public Task AddAppointment(Visit visit)
        {
            var appointmentsCollection = ConnectToMongo<Visit>(AppointmentsCollection);
            return appointmentsCollection.InsertOneAsync(visit);
        }
        public Task UpsertPatient(PatientModel patient)
        {
            var patientCollection = ConnectToMongo<PatientModel>(PatientsCollection);
            var filter = Builders<PatientModel>.Filter.Eq("Id", patient.Id);
            return patientCollection.ReplaceOneAsync(filter, patient, new ReplaceOptions { IsUpsert = true });
        }

    }
}
