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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
            Side_bar_loading();
            AccBar();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
            Dashboard_Page dashboard_Page = new Dashboard_Page();
            MainContainer.Controls.Add(dashboard_Page);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginIn_panel_Paint(object sender, PaintEventArgs e)
        {
            

            
        }

        private void LogoAcc_bar_Paint(object sender, PaintEventArgs e)
        {
            Logo_Acc loac = new Logo_Acc();
            this.Controls.Add(loac);
        }
        private void Side_bar_loading()
        {
            Side_Bar.Controls.Add(new SideBar());
        }
        private void AccBar()
        {
            LogoAcc_bar.Controls.Add(new Logo_Acc());
        }

        public void MainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Side_Bar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
