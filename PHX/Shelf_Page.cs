using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHX.models;

namespace PHX
{
    public partial class Shelf_Page : UserControl
    {
        int counter = 0;
        int Total;
        public Shelf_Page()
        {
            InitializeComponent();
        }
        

        private bool Validation()
        {
            //Numeric no Validation
            Regex check = new Regex("^[0-9]+$");
            bool valid = check.IsMatch(Numeic_no_txtbox.Text);
            if (Numeic_no_txtbox.Text == "" || valid == false)
            {
                check_lbl.ForeColor = Color.Red;
                check_lbl.Text = "invalid input";
                return false;
            }
            else
            {
                check_lbl.Text = "Accepted Data";
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        public async void Submit_btn_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            if (validation)
            {
                // Dashboard_Page dashboard_Page = new Dashboard_Page();
                Shelf_item shelf_Item = new Shelf_item();
                shelf_Item.Controls[2].Text = Name_txtbox.Text;
                shelf_Item.Controls[1].Text = Numeic_no_txtbox.Text;
                flowLayoutPanel1.Parent.Controls[0].Controls.Add(shelf_Item);
                counter++;
                Total = counter;
                /*if (counter != 0)
                {
                    Dashboard_Page dashboard_Page1 = new Dashboard_Page();
                    dashboard_Page1.Controls[11].Text = "aloo";
                }*/


            }/*
            Dashboard_Page dashboard_Page = new Dashboard_Page();
            dashboard_Page.Controls[0].Controls[0].Text = "aloo";*/
            Shelf shelf = new Shelf(Name_txtbox.Text.Trim(), Guid.NewGuid().ToString(), Numeic_no_txtbox.Text.Trim());
            await Manager.databaseManager.AddShelf(shelf);

        

        }

        private void Shelf_Page_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Name_txtBox_Enter(object sender, EventArgs e)
        {
            if (Name_txtbox.Text == "Enter Name")
            {
                Name_txtbox.Text = "";
                ForeColor = Color.Black;
            }
        }

        private void Name_textBox_Leave(object sender, EventArgs e)
        {
            if (Name_txtbox.Text == "")
            {
                Name_txtbox.Text = "Enter Name";
                ForeColor= Color.Gray;
            }
        }

        private void Name_txtbox_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void Numeric_No_txtBox_Enter(object sender, EventArgs e)
        {
            if (Numeic_no_txtbox.Text == "Enter Number")
            {
                Numeic_no_txtbox.Text = "";
                ForeColor = Color.Black;
            }
        }

        private void NUmeric_No_textBox_Leave(object sender, EventArgs e)
        {
            if (Numeic_no_txtbox.Text == "")
            {
                Numeic_no_txtbox.Text = "Enter Number";
                ForeColor = Color.Gray;
            }
        }

        private void Numeic_no_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
                
}
