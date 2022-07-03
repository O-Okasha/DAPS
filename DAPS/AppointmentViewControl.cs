using DAPS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAPS
{
    public partial class AppointmentViewControl : UserControl
    {
        Appointment Appointment;
        public AppointmentViewControl(Appointment appointment)
        {
            InitializeComponent();
            Appointment = appointment;
        }

        private void AppointmentViewControl_Load(object sender, EventArgs e)
        {
            label1.Text = Appointment.Patient.SSN;
            label2.Text = Appointment.dateTime.ToString();

        }
    }
}
