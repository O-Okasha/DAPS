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
    public partial class Sales_Page : UserControl
    {
        public Sales_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            New_Sales_Page sales_Page = new New_Sales_Page();
            this.Parent.Controls[0].Controls.Add(sales_Page);
        }
    }
}
