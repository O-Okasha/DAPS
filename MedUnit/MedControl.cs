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
    public partial class MedControl : UserControl
    {
        public Medicine Medicine { get; set; }
        public MedControl(Medicine med)
        {
            Medicine = med;
            InitializeComponent();
        }

        private void MedControl_Load(object sender, EventArgs e)
        {
            label1.Text = Medicine.ActiveSubstance;
            label2.Text = Medicine.Class;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.Chosen = Medicine;
        }
    }
}
