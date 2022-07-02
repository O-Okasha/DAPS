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
    public partial class AppointmentControl : UserControl
    {
        Visit visit;
        public AppointmentControl()
        {
            InitializeComponent();
        }
        public AppointmentControl(Visit vis)
        {
            InitializeComponent();
            visit = vis;
        }

        private void AppointmentControl_Load(object sender, EventArgs e)
        {
            labelName.Text = visit.Patient.FullName;
            labelTime.Text = visit.dateTime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.patient = visit.Patient;
            MedicalUnitMain medicalUnitMain = new MedicalUnitMain();
            medicalUnitMain.Show();
            this.Parent.Parent.Parent.Parent.Parent.Hide();
        }
    }
}
