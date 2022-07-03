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
    public partial class ViewAppointments : Form
    {
        List<Appointment> appointments = new List<Appointment>();
        public ViewAppointments(List<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;
        }

        private void ViewAppointments_Load(object sender, EventArgs e)
        {
            foreach(Appointment appointment in appointments)
            {
                AppointmentViewControl control = new AppointmentViewControl(appointment);
                Console.WriteLine(1);
                flowLayoutPanel1.Controls.Add(control);
            }

        }
    }
}
