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

        public void PaymentInfo_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Payment_Info payment_Info = new Payment_Info();
            this.Parent.Parent.Controls[0].Controls.Add(payment_Info);
        }

        private void listviewUserControl_Load(object sender, EventArgs e)
        {

        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            calendar cal = new calendar();
            this.Parent.Parent.Controls[0].Controls.Add(cal);
        }

        private void addpatient_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Add_Patient add_Patient = new Add_Patient();
            this.Parent.Parent.Controls[0].Controls.Add(add_Patient);
        }
    }
}
