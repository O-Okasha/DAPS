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
            AddPresetTreatment addPresetTreatment = new AddPresetTreatment();
            content.Controls.Add(addPresetTreatment);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            content.Controls.Add(addService);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDrug addDrug = new AddDrug();
            content.Controls.Add(addDrug);
        }
    }
}
