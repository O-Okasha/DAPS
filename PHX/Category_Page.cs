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
    public partial class Category_Page : UserControl
    {
        public Category_Page()
        {
            InitializeComponent();
        }
        private void Category_Page_Load(object sender,EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Category_item category_Item = new Category_item();
            category_Item.Controls[2].Text = Name_txtbox.Text;
            category_Item.Controls[1].Text = Description_txtbox.Text;
            flowLayoutPanel1.Parent.Controls[0].Controls.Add(category_Item);
        }
    }
}
