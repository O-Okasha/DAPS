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
    public partial class Dashboard_Page : UserControl
    {
        public Dashboard_Page()
        {
            InitializeComponent();
            
        }

        private void label18_load(object sender, EventArgs e)
        {
            //label18.Text == Total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            New_Med_page new_Med_Page = new New_Med_page();
            Low_Stock_Medicine_Itemcs low_Stock_Medicine_Itemcs = new Low_Stock_Medicine_Itemcs();
            low_Stock_Medicine_Itemcs.Controls[4].Text = new_Med_Page.Controls[0].Controls[7].Text;
            low_Stock_Medicine_Itemcs.Controls[2].Text = new_Med_Page.Controls[0].Controls[5].Text;
            low_Stock_Medicine_Itemcs.Controls[1].Text = new_Med_Page.Controls[0].Controls[9].Text;
            low_Stock_Medicine_Itemcs.Controls[0].Text = new_Med_Page.Controls[0].Controls[3].Text;
            low_Stock_Medicine_Itemcs.Controls[3].Text = new_Med_Page.Controls[0].Controls[1].Text;
            flowLayoutPanel1.Parent.Controls[0].Controls.Add(low_Stock_Medicine_Itemcs);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
             
            
                foreach(new_Med_Page.Controls[0].Controls[i])
                {
                    if(textbox1.Text == Search[r].Text)
                    {
                        flowLayoutPanel1.Parent.Controls[0].Controls.Add(low_Stock_Medicine_Itemcs.Controls[r]);
                    }
                }
                 
            */
        }
    }
}
