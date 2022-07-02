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
    public partial class AddPresetTreatment : UserControl
    {
        public AddPresetTreatment()
        {
            InitializeComponent();
        }
        public List<Service> services1 = new List<Service>();

        private async void AddPresetTreatment_Load(object sender, EventArgs e)
        {
            Console.WriteLine('d');
            var services = await Manager.databaseManager.GetAllServices();
 
            foreach (var service in services)
            {
                ProcedureControl procedureControl = new ProcedureControl(service);
                if (service.Type == "General")
                {
                    flowGeneralList.Controls.Add(procedureControl);
                    Console.WriteLine('1');

                }
                else if (service.Type == "Medical")
                {
                    flowMedicalList.Controls.Add(procedureControl);
                    Console.WriteLine('2');
                }
                else
                {
                    flowImagingList.Controls.Add(procedureControl);
                    Console.WriteLine('3');
                }

            }
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            TreatmentPlan plan = new TreatmentPlan(id, textTreatmentName.Text.Trim());

            foreach (AddedProcedureControl control in flowProcedureList.Controls)
            {
                plan.AddService(control.service);
            }
            
            await Manager.databaseManager.AddTreatmentplan(plan);
        }
    }
}
