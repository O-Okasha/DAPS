using DAPS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAPS
{
    public partial class Add_Patient : UserControl
    {
        public Add_Patient()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addpatients_Load(object sender, EventArgs e)
        {
           // listviewUserControl listviewUserControl = new listviewUserControl();
            //lidebar.Controls.Add(listviewUserControl);

        }

        private async void save_Click(object sender, EventArgs e)
        {
 
            PatientModel patient = new PatientModel(textBox2.Text.Trim(), Guid.NewGuid().ToString(), textBox5.Text.Trim(), int.Parse(textBox3.Text.Trim()), textBox1.Text.Trim(), (Gender)gendr.SelectedIndex, address.Text);
            await Manager.DatabaseManager.CreatePatient(patient);
        }
    }
}
