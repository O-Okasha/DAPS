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
    public partial class Prescriptions : Form
    {
        
        public Prescriptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perscription perscription = new Perscription(Manager.patient.Id)
            {
                perscription = Manager.PrescribedMedicines
            };
            Manager.patient.Record.AddPrescription(perscription);
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void add_Click(object sender, EventArgs e)
        {
            PrescribedMedicine prescribed = new PrescribedMedicine(Manager.Chosen, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString(), textBox1.Text.Trim() + ' ' + comboBox1.Text);
            PrescribedMedControl medControl = new PrescribedMedControl(prescribed);
            flowLayoutPanel2.Controls.Add(medControl);
            Manager.PrescribedMedicines.Add(prescribed);

        }

        private async void Prescriptions_Load(object sender, EventArgs e)
        {
            var meds = await Manager.databaseManager.GetAllMedicines();
            foreach (Medicine med in meds)
            {
                MedControl medControl = new MedControl(med);
                flowLayoutPanel1.Controls.Add(medControl);
            }

        }
    }
}
