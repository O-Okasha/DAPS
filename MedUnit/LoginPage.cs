using MedUnit.Models;
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

namespace MedUnit
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            //Email Validation
            Regex check = new Regex(@"^?([A-Za-z0-9]{3,20})\@?([A-Za-z]{3,10}).?(com)$");
            bool valid = check.IsMatch(textBox1.Text);
            if (textBox1.Text == "" || valid == false)
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
            if (textBox2.Text == "")
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

        private async void button1_Click(object sender, EventArgs e)
        {
            var x = await Manager.databaseManager.GetAllDoctors();
            foreach (Doctor doctor in x)
            {
                if ((textBox1.Text.Trim() == doctor.email) && (textBox2.Text.Trim() == doctor.password))
                {
                    Manager.doctor = doctor;
                    bool validation = Validation();
                    if (validation)
                    {
                        MedicalUnitMain medicalUnitMain = new MedicalUnitMain();
                        medicalUnitMain.Show();
                        this.Hide();
                    }
                }
            }
            label1.ForeColor = Color.Red;
            label1.Text = "invalid input";


        }
    }
}
