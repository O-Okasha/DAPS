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
    public partial class New_Purchase_Page : UserControl
    {
        public New_Purchase_Page()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            Puschase puschase = new Puschase();
            this.Parent.Controls[0].Controls.Add(puschase);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List_item list_Item = new List_item();
            flowLayoutPanel1.Parent.Controls[0].Controls.Add(list_Item);

        }
    }
}
