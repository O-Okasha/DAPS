using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAPS.Models
{
    static class Manager
    {
        static public DatabaseManager DatabaseManager = new DatabaseManager();
        static public List<Appointment> Appointments = new List<Appointment>();
        static public List<Bill> bills = new List<Bill>();
        static public PatientModel FocusPatient;
    }
}
