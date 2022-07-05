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
    

    public partial class Medicine_Page : UserControl
    {
       
        public Medicine_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            New_Med_page new_Med_Page = new New_Med_page();
            this.Parent.Controls[0].Controls.Add(new_Med_Page);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {// 1= buying price; 3 = selling price; 5 = batch no; 7 = name; 9 = shelf
            medicine_item medicine_Item = new medicine_item();
            New_Med_page new_Med_Page = new New_Med_page();
            
            medicine_Item.Controls[5].Text = new_Med_Page.Controls[0].Controls[7].Text;
            medicine_Item.Controls[4].Text = new_Med_Page.Controls[0].Controls[5].Text;
            medicine_Item.Controls[3].Text = new_Med_Page.Controls[0].Controls[9].Text;
            medicine_Item.Controls[2].Text = new_Med_Page.Controls[0].Controls[3].Text;
            medicine_Item.Controls[1].Text = new_Med_Page.Controls[0].Controls[1].Text;
            flowPanelcontainer.Parent.Controls[1].Controls.Add(medicine_Item);
        }
    }
}
