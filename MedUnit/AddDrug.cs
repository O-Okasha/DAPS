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
    public partial class AddDrug : UserControl
    {
        public AddDrug()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            int price = int.Parse(textBox3.Text.Trim());
            Medicine med = new Medicine(textBox1.Text.Trim(), price, id, textBox2.Text.Trim());
            await Manager.databaseManager.AddMedicine(med);

        }

        private void AddDrug_Load(object sender, EventArgs e)
        {

        }
    }
}
