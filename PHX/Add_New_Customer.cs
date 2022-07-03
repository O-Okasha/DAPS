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
    public partial class Add_New_Customer : UserControl
    {
        public Add_New_Customer()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            Customer_Page customer_Page = new Customer_Page();
            this.Parent.Controls[0].Controls.Add(customer_Page);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Enter Name")
            {
                textBox5.Text = "";
                ForeColor = Color.Black;
            }
        }

        private void txtBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Enter Name";
                ForeColor = Color.Gray;
            }
        }
        private void txtBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Enter Email")
            {
                textBox6.Text = "";
                ForeColor = Color.Black;
            }
        }

        private void txtBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Enter Email";
                ForeColor = Color.Gray;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Phone")
            {
                textBox1.Text = "";
                ForeColor = Color.Black;
            }
        }

        private void txtBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Phone";
                ForeColor = Color.Gray;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Age")
            {
                textBox2.Text = "";
                ForeColor = Color.Black;
            }
        }

        private void txtBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter Age";
                ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select Gender")
            {
                comboBox1.Text = "";
                ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Select Gender";
                ForeColor = Color.Gray;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Enter Address")
            {
                textBox4.Text = "";
                ForeColor = Color.Black;
            }
        }

        private void txtbox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Enter Address";
                ForeColor = Color.Gray;
            }
        }
    }
}
