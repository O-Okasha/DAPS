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
    public partial class Stock_List_Page : UserControl
    {
        public Stock_List_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            this.Parent.Controls[0].Controls.Add(new_Purchase_Page);
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            New_Med_page new_Med_Page = new New_Med_page();
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            StockList_item stockList_Item = new StockList_item();

            stockList_Item.Controls[4].Text = new_Purchase_Page.Controls[0].Controls[23].Text;
            stockList_Item.Controls[2].Text = new_Purchase_Page.Controls[0].Controls[1].Text;
            stockList_Item.Controls[1].Text = new_Purchase_Page.Controls[0].Controls[22].Text;

            stockList_Item.Controls[3].Text = new_Med_Page.Controls[0].Controls[3].Text;

            stockList_Item.Controls[0].Text = new_Purchase_Page.Controls[0].Controls[3].Text;

            flowLayoutPanel1.Parent.Controls[0].Controls.Add(stockList_Item);
        }
    }
}
