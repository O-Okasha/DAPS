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

        private void button5_Click(object sender, EventArgs e)
        {
            Add_Supplier add_Supplier = new Add_Supplier();
            Supplier_item supplier_Item = new Supplier_item();

            supplier_Item.Controls[4].Text = add_Supplier.Controls[0].Controls[1].Text;
            supplier_Item.Controls[2].Text = add_Supplier.Controls[0].Controls[0].Text;
            supplier_Item.Controls[3].Text = add_Supplier.Controls[0].Controls[7].Text;

            flowLayoutPanel1.Parent.Controls[0].Controls.Add(supplier_Item);
        }
    }
}
