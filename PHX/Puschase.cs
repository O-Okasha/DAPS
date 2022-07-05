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
    public partial class Puschase : UserControl
    {
        public Puschase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            new_Purchase_Page.Controls[0].Controls[32].Text = "Purchase";
            new_Purchase_Page.Controls[0].Controls[17].Text = "Save Purchase";
            new_Purchase_Page.Controls[0].Controls[0].Visible = false;
            new_Purchase_Page.Controls[0].Controls[1].Visible = false;
            this.Parent.Controls[0].Controls.Add(new_Purchase_Page);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 7 = status,                 , 9 = payment 
            Purchase_item Purchase_Item = new Purchase_item();
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            Purchase_Item.Controls[1].Text = new_Purchase_Page.Controls[0].Controls[9].Text;
            Purchase_Item.Controls[4].Text = new_Purchase_Page.Controls[0].Controls[14].Text;
            Purchase_Item.Controls[2].Text = new_Purchase_Page.Controls[0].Controls[11].Text;
            Purchase_Item.Controls[3].Text = new_Purchase_Page.Controls[0].Controls[25].Text;
            Purchase_Item.Controls[5].Text = new_Purchase_Page.Controls[0].Controls[21].Text;
            flowLayoutPanel1.Parent.Controls[0].Controls.Add(Purchase_Item);
        }
    }
}
