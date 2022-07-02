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
    public partial class Main_page : Form
    {
        public Main_page()
        {
            InitializeComponent();
            listView_load();
        }
        private void listView_load()
        {
            panel1.Controls.Add(new listviewUserControl());
        }

        private void Main_page_Load(object sender, EventArgs e)
        {
            Payment_Info payment = new Payment_Info();
            MainPanel.Controls.Add(payment);
        }

        private void listPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
