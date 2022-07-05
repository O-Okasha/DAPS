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
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            new_Purchase_Page.Controls[0].Controls[32].Text = "Sales";
            new_Purchase_Page.Controls[0].Controls[17].Text = "Save Sale";
            new_Purchase_Page.Controls[0].Controls[30].Visible = false;
            new_Purchase_Page.Controls[0].Controls[29].Visible = false;
            this.Parent.Controls[0].Controls.Add(new_Purchase_Page);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sales_item sales_Item = new Sales_item();
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            sales_Item.Controls[5].Text = new_Purchase_Page.Controls[0].Controls[0].Text;
            sales_Item.Controls[3].Text = new_Purchase_Page.Controls[0].Controls[19].Controls[0].Text;
            sales_Item.Controls[2].Text = new_Purchase_Page.Controls[0].Controls[8].Text;
            sales_Item.Controls[4].Text = new_Purchase_Page.Controls[0].Controls[14].Text;
            sales_Item.Controls[1].Text = new_Purchase_Page.Controls[0].Controls[9].Text;
            flowLayoutPanel1.Parent.Controls[0].Controls.Add(sales_Item);
        }
    }
}
