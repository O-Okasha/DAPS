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
    public partial class listviewUserControl : UserControl
    {
        public listviewUserControl()
        {
            InitializeComponent();
        }

        private void PaymentInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentInfoDental pay = new PaymentInfoDental();
            pay.Show();
        }

        private void listviewUserControl_Load(object sender, EventArgs e)
        {

        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            calendar cal = new calendar();
            cal.Show();
        }

        private void addpatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            addpatients addpatients = new addpatients();
            addpatients.Show();
        }
    }
}
