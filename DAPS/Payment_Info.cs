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
           // listviewUserControl listviewUserControl = new listviewUserControl();
            //panel1.Controls.Add(listviewUserControl);

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            flowpanelservices.Controls.Add(paymentUserControl);
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {/*
            PaymentUserControl paymentUserControl = new PaymentUserControl();
            flowpanelservices.Parent.Controls[0].Controls.Add(paymentUserControl);
            TotalUserControl totalUserControl = new TotalUserControl();
            paneltotal.Parent.Controls[0].Controls.Add(totalUserControl);*/
        }
    }
}
