using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAPS.Models;
using MySql.Data.MySqlClient;

namespace DAPS
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            var time = DaysUserControl.static_day + "/"  + calendar.static_month + "/" + calendar.static_year;
            textdate.Text = time;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.MinDate = DateTime.Parse(time + ' ' + "10:00:00 AM");
            dateTimePicker1.MaxDate = DateTime.Parse(time + ' ' + "10:00:00 PM");


        }
        private async void save_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dateTimePicker1.Value.Date.ToString().Split(' ')[0]);
            var patient = await Manager.DatabaseManager.GetPatient(textSSN.Text.Trim());
            Console.WriteLine(patient[0].SSN);
            Appointment appiontment = new Appointment(Guid.NewGuid().ToString(), textSSN.Text.Trim(), dateTimePicker1.Value, dateTimePicker1.Value.Date.ToString().Split(' ')[0], patient[0]);
            await Manager.DatabaseManager.CreateAppointment(appiontment);
            FHIRManager.SendAppointment(appiontment);

        }
    }
}
