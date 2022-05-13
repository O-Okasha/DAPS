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
    public partial class Login_control : UserControl
    {
        public Login_control()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            
            Main_Page main_Page = new Main_Page();
            this.Hide();
            main_Page.Show();
            //this.Parent.Parent.Parent.Dispose();
        }
    }
}
