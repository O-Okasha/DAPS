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

namespace PHX
{
    public partial class Shelf_Page : UserControl
    {
        private Shelf_item shelf;
        public Shelf_Page()
        {
            InitializeComponent();
        }
        public void item(Shelf_item test)
        {
            shelf = test;
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

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            if (validation)
            {

                Shelf_item shelf_Item = new Shelf_item();
                shelf_Item.Controls[2].Text = Name_txtbox.Text;
                shelf_Item.Controls[1].Text = Numeic_no_txtbox.Text;
                flowLayoutPanel1.Parent.Controls[0].Controls.Add(shelf_Item);
            }
        }

        private void Shelf_Page_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
