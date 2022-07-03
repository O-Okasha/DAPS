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
    public partial class PaymentUserControl : UserControl
    {
        Bill bill1 = new Bill();
        public PaymentUserControl(Bill bill)
        {
            InitializeComponent();
            this.bill1 = bill;
        }

        private void PaymentUserControl_Load(object sender, EventArgs e)
        {
            Pri.Text = bill1.total.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var patient =  await Manager.DatabaseManager.GetPatient(bill1.patientSSN);
            foreach (PatientModel pat in patient)
            {
                Manager.FocusPatient = pat;
            }
            this.Parent.Parent.Controls[4].Text = Manager.FocusPatient.SSN;
            this.Parent.Parent.Controls[5].Text = Manager.FocusPatient.FullName;
            this.Parent.Parent.Controls[6].Text = Manager.FocusPatient.Age.ToString();
        }
    }
}
