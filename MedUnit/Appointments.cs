using MedUnit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedUnit
{
    public partial class Appointments : UserControl
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.refresh();
            foreach (var item in Manager.visits)
            {
                AppointmentControl appointmentControl = new AppointmentControl(item);
                panel1.Controls.Add(appointmentControl);
            }
        }
    }
}
