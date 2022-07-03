using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAPS
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
            bool valid = check.IsMatch(txtUsername.Text);
            if (txtUsername.Text == "" || valid == false)
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
            if (txtPassword.Text == "")
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calendarpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            if (validation)
            {
                Main_page main_Page = new Main_page();
                main_Page.Show();
                this.Hide();
            }
        }
    }
}
