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
    public partial class Prescription : UserControl
    {
        int Counter = 0;
        long a;
        long b;
        long c;
        string x;
        public Prescription()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Applybtn_Click(object sender, EventArgs e)
        {/*
            Prescription_item prescription_Item = new Prescription_item();
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            prescription_Item.Controls[0].Text = new_Purchase_Page.Controls[0].Controls[9].Text;
            prescription_Item.Controls[3].Text = new_Purchase_Page.Controls[0].Controls[14].Text;
            prescription_Item.Controls[1].Text = new_Purchase_Page.Controls[0].Controls[11].Text;
            prescription_Item.Controls[2].Text = new_Purchase_Page.Controls[0].Controls[25].Text;
            prescription_Item.Controls[4].Text = new_Purchase_Page.Controls[0].Controls[21].Text;
            flowLayoutPanel1.Parent.Controls[0].Controls.Add(prescription_Item);*/
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            // 5 = no, 2 = name, 3 = amt, 4 = qnt, 4 = price

            Prescription_item prescription_Item = new Prescription_item();
            Counter++;
            prescription_Item.Controls[5].Text = Counter.ToString();
            prescription_Item.Controls[2].Text = new_Purchase_Page.Controls[0].Controls[0].Text;
            /*prescription_Item.Controls[5].Text = new_Med_Page.Controls[0].Controls[1].Text;
            prescription_Item.Controls[4].Text = quantitytextBox.Text;
            a = Convert.ToInt64(new_Med_Page.Controls[0].Controls[1].Text);
            b = Convert.ToInt64(quantitytextBox.Text);
            c = a * b;
            x = Convert.ToString(c);
            prescription_Item.Controls[3].Text = x;
*/
            flowLayoutPanel1.Parent.Controls[0].Controls.Add(prescription_Item);

        }
    }
}
