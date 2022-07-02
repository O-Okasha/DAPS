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
    public partial class PrescribedMedControl : UserControl
    {
        PrescribedMedicine prescribed;
        public PrescribedMedControl(PrescribedMedicine p)
        {
            InitializeComponent();
            prescribed = p;
        }

        private void PrescribedMedControl_Load(object sender, EventArgs e)
        {
            active.Text = prescribed.Medicine.ActiveSubstance;
            _class.Text = prescribed.Medicine.Class;
            dose.Text = prescribed.Dose;

        }

        private void remove_Click(object sender, EventArgs e)
        {
            Manager.PrescribedMedicines.Remove(prescribed);
            this.Dispose();
        }
    }
}
