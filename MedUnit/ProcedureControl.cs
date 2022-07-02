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
    public partial class ProcedureControl : UserControl
    {
        Service service;

        public ProcedureControl()
        {
            InitializeComponent();
        }
        public ProcedureControl(Service ser)
        {
            service = ser;
            InitializeComponent();
        }


        private void ProcedureControl_Load(object sender, EventArgs e)
        {
            procedureName.Text = service.Name;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddedProcedureControl addedProcedureControl = new AddedProcedureControl(service);
            this.Parent.Parent.Controls[4].Controls.Add(addedProcedureControl);
        }
    }
}
