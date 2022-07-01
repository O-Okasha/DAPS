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
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Background background = new Background();
            this.Parent.Parent.Controls[0].Controls.Clear();
            this.Parent.Parent.Controls[0].Controls.Add(background);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xray xray = new Xray();
            this.Parent.Parent.Controls[0].Controls.Clear();
            this.Parent.Parent.Controls[0].Controls.Add(xray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Parent.Parent.Controls[0].Controls.Clear();
            this.Parent.Parent.Controls[0].Controls.Add(main);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InnerAppointment appointment = new InnerAppointment();
            this.Parent.Parent.Controls[0].Controls.Clear();
            this.Parent.Parent.Controls[0].Controls.Add(appointment);

        }
    }
}
