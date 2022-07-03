using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHX
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            //Email Validation
            Regex check = new Regex(@"^?([A-Za-z0-9]{3,20})\@?([A-Za-z]{3,10}).?(com)$");
            bool valid = check.IsMatch(Email_txtbox.Text);
            if (Email_txtbox.Text == "" || valid == false)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "invalid input";
                return false;
            }
            else
            {
                label1.Text = "";
            }
            //password validation
            if (Pass_txtbox.Text == "")
            {
                label1.ForeColor = Color.Red;
                label1.Text = "invalid input";
                return false;
            }
            else
            {
                label1.Text = "";
            }
            return true;
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            if (validation)
            {
                Main_Page main_Page = new Main_Page();
                main_Page.Show();
                this.Hide();
            }


        }

        private void Login_control_Load(object sender, EventArgs e)
        {

        }

        private void Email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void emailtextbox_Enter(object sender, EventArgs e)
        {
            if (Email_txtbox.Text == "Enter Email")
            {
                Email_txtbox.Text = "";
                ForeColor = Color.Black;
            }
        }

        private void emailtextbox_Leave(object sender, EventArgs e)
        {
            if (Email_txtbox.Text == "")
            {
                Email_txtbox.Text = "Enter Name";
                ForeColor = Color.Gray;
            }
        }
        private void passwordtxtbox_Enter(object sender, EventArgs e)
        {

        }

        private void passwordtxtbox_Leave(object sender, EventArgs e)
        {

        }
    }
}
