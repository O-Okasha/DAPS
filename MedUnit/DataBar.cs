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
    public partial class DataBar : UserControl
    {
        public DataBar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Parent.Parent.Hide();
        }

        private void DataBar_Load(object sender, EventArgs e)
        {
            if (Manager.patient != null)
            {
                textName.Text = Manager.patient.FullName;
                textAge.Text = Manager.patient.Age.ToString();
                textGender.Text = Manager.patient.Gender.ToString();
                textVisits.Text = (Manager.patient.Record.Visits.Count + 1).ToString();
                checkAllergy.Checked = Manager.patient.Record.Allergies;
                checkCancer.Checked = Manager.patient.Record.Cancer;
                checkThinner.Checked = Manager.patient.Record.Bloodthinner;
            }
        }
    }
}
