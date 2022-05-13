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
    public partial class Customer_Page : UserControl
    {
        public Customer_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            Add_New_Customer add_New_Customer = new Add_New_Customer();
            this.Parent.Controls[0].Controls.Add(add_New_Customer);
        }
    }
}
