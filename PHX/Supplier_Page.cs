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
    public partial class Supplier_Page : UserControl
    {
        public Supplier_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            Add_Supplier add_Supplier = new Add_Supplier();
            this.Parent.Controls[0].Controls.Add(add_Supplier);
        }
    }
}
