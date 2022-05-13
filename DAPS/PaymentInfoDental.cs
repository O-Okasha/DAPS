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
    public partial class PaymentInfoDental : Form
    {
        public PaymentInfoDental()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            listviewUserControl listview = new listviewUserControl();
            panel1.Controls.Add(listview);
        }

        private void flowpanelservices_Paint(object sender, PaintEventArgs e)
        {
            PaymentUserControl paymentUser = new PaymentUserControl ();

            flowpanelservices.Controls.Add(paymentUser);
        }

        private void paneltotal_Paint(object sender, PaintEventArgs e)
        {
            TotalUserControl totalUser = new TotalUserControl ();
            paneltotal.Controls.Add(totalUser);
        }
    }
}
