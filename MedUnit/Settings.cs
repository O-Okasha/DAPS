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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            AddPresetTreatment addPresetTreatment = new AddPresetTreatment();
            content.Controls.Add(addPresetTreatment);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            AddService addService = new AddService();
            content.Controls.Add(addService);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            AddDrug addDrug = new AddDrug();
            content.Controls.Add(addDrug);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedicalUnitMain medicalUnitMain = new MedicalUnitMain();
            medicalUnitMain.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            Appointments appointments = new Appointments();
            content.Controls.Add(appointments);
        }
    }
}
