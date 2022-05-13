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
    public partial class addpatients : Form
    {
        public addpatients()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addpatients_Load(object sender, EventArgs e)
        {
            listviewUserControl listviewUserControl = new listviewUserControl();
            slidebar.Controls.Add(listviewUserControl);

        }
    }
}
