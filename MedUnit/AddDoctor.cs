using MedUnit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedUnit
{
    public partial class AddDoctor : UserControl
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor()
            {
                email = textBox1.Text.Trim(),
                password = textBox3.Text.Trim(),
                fname = textBox2.Text.Trim(),
                lname = textBox4.Text.Trim(),
                LicenseNumber = textBox7.Text.Trim(),
            };
            await Manager.databaseManager.AddDoctor(doctor);
        }
    }
}
