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
    public partial class Payment_Info : UserControl
    {
        public Payment_Info()
        {
            InitializeComponent();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowpanelservices_Paint(object sender, PaintEventArgs e)
        {
            //PaymentUserControl paymentUserControl = new PaymentUserControl();
            //  flowpanelservices.Controls.Add(paymentUserControl);
        }

        private void paneltotal_Paint(object sender, PaintEventArgs e)
        {
            TotalUserControl totalUser = new TotalUserControl();
            paneltotal.Controls.Add(totalUser);
        }

        private void PaymentInfoDental_Load(object sender, EventArgs e)
        {
           if (Manager.FocusPatient != null)
            {
                textBox1.Text = Manager.FocusPatient.SSN;
                textBox2.Text = Manager.FocusPatient.FullName;
                textBox3.Text = Manager.FocusPatient.Age.ToString();
            }
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {/*
            PaymentUserControl paymentUserControl = new PaymentUserControl();
            flowpanelservices.Parent.Controls[0].Controls.Add(paymentUserControl);
            TotalUserControl totalUserControl = new TotalUserControl();
            paneltotal.Parent.Controls[0].Controls.Add(totalUserControl);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FHIRInvoice invoice = FHIRManager.GetInvoice();
            Bill bill = new Bill();
            bill.date = invoice.date;
            bill.patientSSN = invoice.id;
            bill.total = int.Parse(invoice.TotalNet["value"]);
            bill.Id = Guid.NewGuid().ToString();
            PaymentUserControl control = new PaymentUserControl(bill);
            flowpanelservices.Controls.Add(control);

        }
    }
}
