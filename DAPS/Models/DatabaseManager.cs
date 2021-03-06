using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAPS.Models
{
    public class DatabaseManager
    {
        private const string ConnectionString = "mongodb://localhost:27017";
        private const string database = "registration";
        private const string PatientsCollection = "patients";
        private const string BillsCollection = "bills";
        private const string ServicesCollection = "services";
        private const string AppointmentsCollection = "appointments";

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(database);
            return db.GetCollection<T>(collection);
        }

        public async Task<List<Appointment>> GetAllAppointments()
        {
            var appointmentCollection = ConnectToMongo<Appointment> (AppointmentsCollection);
            var results = await appointmentCollection.FindAsync(_ => true);
            return results.ToList();
        }
        public async Task<List<Bill>> GetAllBills()
        {
            var billCollection = ConnectToMongo<Bill>(BillsCollection);
            var results = await billCollection.FindAsync(_ => true);
            return results.ToList();
        }
        public async Task<List<PatientModel>> GetAllPatients()
        {
            var billCollection = ConnectToMongo<PatientModel>(PatientsCollection);
            var results = await billCollection.FindAsync(_ => true);
            return results.ToList();
        }
        public async Task<List<PatientModel>> GetPatient(string SSN)
        {
            var patientCollection = ConnectToMongo<PatientModel>(PatientsCollection);
            var patientResult = await patientCollection.FindAsync(x => x.SSN == SSN);
            return patientResult.ToList();
        }
        public async Task<List<Bill>> GetBill(Bill bill)
        {
            var patientCollection = ConnectToMongo<Bill>(BillsCollection);
            var patientResult = await patientCollection.FindAsync(x => x.patientSSN == bill.patientSSN);
            return patientResult.ToList();
        }
        public Task UpsertPatient(PatientModel patient)
        {
            var patientCollection = ConnectToMongo<PatientModel>(PatientsCollection);
            var filter = Builders<PatientModel>.Filter.Eq("Id", patient.Id);
            return patientCollection.ReplaceOneAsync(filter, patient, new ReplaceOptions { IsUpsert = true });
        }
        public Task UpsertBill(Bill bill)
        {
            var patientCollection = ConnectToMongo<Bill>(BillsCollection);
            var filter = Builders<Bill>.Filter.Eq("PatientSSD", bill.patientSSN);
            return patientCollection.ReplaceOneAsync(filter, bill, new ReplaceOptions { IsUpsert = true });
        }
        public Task CreateBill(Bill bill)
        {
            var billCollection = ConnectToMongo<Bill>(BillsCollection);
            return billCollection.InsertOneAsync(bill);
        }
        public Task CreatePatient(PatientModel patient)
        {
            var billCollection = ConnectToMongo<PatientModel>(PatientsCollection);
            return billCollection.InsertOneAsync(patient);
        }
        public Task CreateAppointment(Appointment appiontment)
        {
            var billCollection = ConnectToMongo<Appointment>(AppointmentsCollection);
            return billCollection.InsertOneAsync(appiontment);
        }
        public async Task<List<Appointment>> GetEvents(string date)
        {
            var appointmentCollection = ConnectToMongo<Appointment>(AppointmentsCollection);
            var patientResults = await appointmentCollection.FindAsync(x => x.textID == date);
            return patientResults.ToList();
        }

    }
}
