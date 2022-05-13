using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHX
{
    public partial class Add_New_Customer : UserControl
    {
        public Add_New_Customer()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            Customer_Page customer_Page = new Customer_Page();
            this.Parent.Controls[0].Controls.Add(customer_Page);
        }
    }
}
