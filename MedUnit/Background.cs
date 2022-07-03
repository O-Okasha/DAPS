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
    public partial class Background : UserControl
    {
        public Background()
        {
            InitializeComponent();
        }

        private void Background_Load(object sender, EventArgs e)
        {
            if (Manager.patient != null)
            {
                richfhist.Text = Manager.patient.Record.FamilyHistory;
                richhist.Text = Manager.patient.Record.PersonalHistory;
                richcomp.Text = Manager.visitDetails.complaints;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.visitDetails.AddComplaint(richcomp.Text.Trim());
            Manager.patient.Record.AddFamilyHistory(richfhist.Text.Trim());
            Manager.patient.Record.AddHistory(richhist.Text.Trim());
            if (richaller.Text.Count() > 0)
            {
                Manager.patient.Record.AllergyDetails = richaller.Text.Trim();
                Manager.patient.Record.Allergies = true;
            }
            

        }

    }
}
