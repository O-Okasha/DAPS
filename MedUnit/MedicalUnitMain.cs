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
    public partial class MedicalUnitMain : Form
    {
        public MedicalUnitMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Navbar navbar = new Navbar();
            DataBar dataBar = new DataBar();
            Main main = new Main();
            Content.Controls.Add(main);
            DataPanel.Controls.Add(dataBar);
            bar.Controls.Add(navbar);

        }

        private void bar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
