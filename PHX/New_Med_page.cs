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
    public partial class New_Med_page : UserControl
    {
        public New_Med_page()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            Medicine_Page medicine_Page = new Medicine_Page();
            this.Parent.Controls[0].Controls.Add(medicine_Page);
           // models.Medicine medicine = new models.Medicine(Name_txtbox.Text.Trim(), Guid.NewGuid().ToString(), Numeic_no_txtbox.Text.Trim());
            //await Manager.databaseManager.AddShelf(shelf);


        }
    }
}
