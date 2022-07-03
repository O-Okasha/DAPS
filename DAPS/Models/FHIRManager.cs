using Hl7.Fhir.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace DAPS.Models
{
    public static class FHIRManager
    {
        public async static void SendInvoice(Bill bill)
        {
            FHIRInvoice invoice = new FHIRInvoice();
            invoice.date = bill.date;
            invoice.id = bill.patientSSN;
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("value", bill.total.ToString());
            data.Add("Currency", "EGP");
            invoice.TotalNet = data;

            var json = JsonConvert.SerializeObject(invoice);
            Console.WriteLine(json);

            using (var client  = new HttpClient())
            {
                var endpoint = new Uri("https://regdocapi.herokuapp.com/bills");
                var payload = new StringContent(json, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(endpoint, payload);
                Console.WriteLine(result);
            }

        }
        public async static void SendPatient(PatientModel p)
        {
            FHIRPatient patient = new FHIRPatient();
            patient.id = p.SSN;
            patient.age = p.Age.ToString();
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            Dictionary<string, string> data2 = new Dictionary<string, string>();
            data2.Add("use", "home");
            data2.Add("type", "both");
            data2.Add("text", p.Address);
            data.Add(data2);
            patient.address = data;

            var json = JsonConvert.SerializeObject(patient);
            Console.WriteLine(json);

            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://regdocapi.herokuapp.com/patient");
                var payload = new StringContent(json, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(endpoint, payload);
                Console.WriteLine(result);
            }


        }
        public async static void SendAppointment(Appointment appointment)
        {

            var json = JsonConvert.SerializeObject(appointment);
            Console.WriteLine(json);

            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://regdocapi.herokuapp.com/appointments");
                var payload = new StringContent(json, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(endpoint, payload);
                Console.WriteLine(result);
            }


        }
        public static FHIRInvoice GetInvoice()
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://regdocapi.herokuapp.com/bills");
                var result = client.GetAsync(endpoint).Result;
                Console.WriteLine(result.Content.ReadAsStringAsync().Result);
                var c = result.Content.ReadAsStringAsync().Result;

                List<FHIRInvoice> x = JsonConvert.DeserializeObject<List<FHIRInvoice>>(c);
                foreach (FHIRInvoice xItem in x)
                {
                    return xItem;
                }
                return x[0];
            }

        }

    }
}
