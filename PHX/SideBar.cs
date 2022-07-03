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
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnDashbourd_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Dashboard_Page dashboard_Page = new Dashboard_Page();
            this.Parent.Parent.Controls[0].Controls.Add(dashboard_Page);
           
        }

        private void Shelfbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Shelf_Page shelf_Page = new Shelf_Page();
            this.Parent.Parent.Controls[0].Controls.Add(shelf_Page);
        }

        private void Categorybtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Category_Page category_Page = new Category_Page();  
            this.Parent.Parent.Controls[0].Controls.Add(category_Page);
        }

        private void Medbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Medicine_Page Medicine_Page = new Medicine_Page();
            this.Parent.Parent.Controls[0].Controls.Add(Medicine_Page);
        }

        private void Customersbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Customer_Page customer_Page = new Customer_Page();
            this.Parent.Parent.Controls[0].Controls.Add(customer_Page);
        }

        private void suppbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Supplier_Page supplier_Page = new Supplier_Page();
            this.Parent.Parent.Controls[0].Controls.Add(supplier_Page);
        }

        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Puschase puschase = new Puschase();
            this.Parent.Parent.Controls[0].Controls.Add(puschase);
        }

        private void stockListbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Stock_List_Page stock_List_Page = new Stock_List_Page();
            this.Parent.Parent.Controls[0].Controls.Add(stock_List_Page);
        }

        private void Salesbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Sales_Page sales_Page = new Sales_Page();
            this.Parent.Parent.Controls[0].Controls.Add(sales_Page);
        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Store_sett_page store_Sett_Page = new Store_sett_page();
            this.Parent.Parent.Controls[0].Controls.Add(store_Sett_Page);
        }

        private void Prescriptionbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls[0].Controls.Clear();
            Prescription prescription = new Prescription();
            this.Parent.Parent.Controls[0].Controls.Add(prescription);

        }
    }
}
