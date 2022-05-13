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
    public partial class Add_Supplier : UserControl
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            Supplier_Page supplier_Page = new Supplier_Page();
            this.Parent.Controls[0].Controls.Add(supplier_Page);
        }
    }
}
