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
    public partial class ServiceControl : UserControl
    {
        public Service Service { get; set; }
        public ServiceControl(Service service)
        {
            InitializeComponent();
            Service = service;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Manager.ActivePlan.CompleteService(Service);
                Manager.CurrentBill.total += Service.price;
            }
        }

        private void ServiceControl_Load(object sender, EventArgs e)
        {
            label1.Text = Service.Name;
        }
    }
}
