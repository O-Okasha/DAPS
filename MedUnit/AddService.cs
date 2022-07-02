using MedUnit.Models;
using System;
using System.Windows.Forms;
using MongoDB.Driver;

namespace MedUnit
{
    public partial class AddService : UserControl
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private async void Save_Click(object sender, EventArgs e)
        {
            string ID = Guid.NewGuid().ToString().Trim().Replace('-','e');
            int price = int.Parse(textPrice.Text.Trim());
            Service service = new Service(ID, textName.Text.Trim(), textDiscription.Text.Trim(), price, comboBox1.Text.Trim());
            DatabaseManager database = new DatabaseManager();
            await database.AddService(service);
        }
    }
}
