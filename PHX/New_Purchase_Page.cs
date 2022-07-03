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
    public partial class New_Purchase_Page : UserControl
    {
        int Counter = 0;
        long a;
        long b;
        long c;
        string x;
        public New_Purchase_Page()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Puschase puschase = new Puschase();
            Sales_Page sales_Page = new Sales_Page();
            if (SavePurchasebtn.Text == "Save Purchase")
            {
                this.Parent.Controls[0].Controls.Clear();
               
                this.Parent.Controls[0].Controls.Add(puschase);
            }
            else
            {
                this.Parent.Controls[0].Controls.Clear();

                this.Parent.Controls[0].Controls.Add(sales_Page);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            New_Med_page new_Med_Page = new New_Med_page();
            // 6 = no, 2 = name, 3 = amt, 4 = qnt, 5 = unit
            List_item list_Item = new List_item();
            Counter++;
            list_Item.Controls[6].Text = Counter.ToString();
            list_Item.Controls[2].Text = MedicineComboBox.Text;
            list_Item.Controls[5].Text = new_Med_Page.Controls[0].Controls[1].Text;
            list_Item.Controls[4].Text = quantitytextBox.Text;
            a = Convert.ToInt64(new_Med_Page.Controls[0].Controls[1].Text);
            b = Convert.ToInt64(quantitytextBox.Text);
            c = a * b;
            x = Convert.ToString(c);
            list_Item.Controls[3].Text = x;

            flowLayoutPanel1.Parent.Controls[1].Controls.Add(list_Item);

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {/*
            New_Med_page new_Med_Page = new New_Med_page();
            new_Med_Page.Controls[0].Controls[1].Text = la*/
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            New_Med_page new_Med_Page = new New_Med_page();
            new_Med_Page.Controls[0].Controls[1].Text = BPVlbl.Text;
            new_Med_Page.Controls[0].Controls[5].Text = BNVlbl.Text;
        }

        private void TotalNolbl_Click(object sender, EventArgs e)
        {
            //foreach(no)
        }

        private void DiscountlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
