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
        {
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            // 5 = no, 2 = name, 3 = amt, 4 = qnt, 4 = price
            New_Med_page new_Med_Page = new New_Med_page();
            Prescription_item prescription_Item = new Prescription_item();
            Counter++;
            prescription_Item.Controls[5].Text = Counter.ToString();
            prescription_Item.Controls[0].Text = new_Purchase_Page.Controls[0].Controls[25].Text;
            prescription_Item.Controls[4].Text = new_Med_Page.Controls[0].Controls[3].Text;
            prescription_Item.Controls[3].Text = new_Purchase_Page.Controls[0].Controls[24].Text;
            a = Convert.ToInt64(new_Med_Page.Controls[0].Controls[3].Text);
            b = Convert.ToInt64(new_Purchase_Page.Controls[0].Controls[24].Text);
            c = a * b;
            x = Convert.ToString(c);
            prescription_Item.Controls[2].Text = x;

            flowLayoutPanel1.Parent.Controls[0].Controls.Add(prescription_Item);
            // 3  5
            Store_sett_page store_Sett_Page = new Store_sett_page();
            StoreNamelbl.Text = store_Sett_Page.Controls[0].Controls[1].Text;
            StoreEmaillbl.Text = store_Sett_Page.Controls[0].Controls[9].Text;
            StorePhonelbl.Text = store_Sett_Page.Controls[0].Controls[3].Text;
            StoreAddresslbl.Text = store_Sett_Page.Controls[0].Controls[5].Text;

            Add_New_Customer add_New_Customer = new Add_New_Customer();
            CustomerNamelbl.Text = add_New_Customer.Controls[0].Controls[3].Text;
            CustomerPhonelbl.Text = add_New_Customer.Controls[0].Controls[9].Text;

            PurchaseCodelbl.Text = new_Purchase_Page.Controls[0].Controls[21].Text;
            Datelbl.Text = new_Purchase_Page.Controls[0].Controls[2].Text;





        }
    }
}
