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

        private void Showbtn_Click(object sender, EventArgs e)
        {
            
            Add_New_Customer add_New_Customer = new Add_New_Customer();
            Customer_item customer_Item = new Customer_item();

            customer_Item.Controls[3].Text = add_New_Customer.Controls[0].Controls[3].Text;
            customer_Item.Controls[1].Text = add_New_Customer.Controls[0].Controls[2].Text;
            customer_Item.Controls[2].Text = add_New_Customer.Controls[0].Controls[9].Text;
            
            flowLayoutPanel1.Parent.Controls[0].Controls.Add(customer_Item);
        }
    }
}
