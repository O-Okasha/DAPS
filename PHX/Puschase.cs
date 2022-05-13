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
    public partial class Puschase : UserControl
    {
        public Puschase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            New_Purchase_Page new_Purchase_Page = new New_Purchase_Page();
            this.Parent.Controls[0].Controls.Add(new_Purchase_Page);

        }
    }
}
