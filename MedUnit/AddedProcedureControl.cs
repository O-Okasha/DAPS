using MedUnit.Models;
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
    public partial class AddedProcedureControl : UserControl
    {
        public Service service;
        public AddedProcedureControl()
        {
            InitializeComponent();
        }
        public AddedProcedureControl(Service ser)
        {
            InitializeComponent();
            service = ser;
        }

        private void AddedProcedureControl_Load(object sender, EventArgs e)
        {
            label1.Text = service.Name;
            label2.Text = service.Description;
            label3.Text = service.price.ToString();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
