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
    public partial class AddProblem : UserControl
    {
        public List<TreatmentPlan> Plans;
        public AddProblem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Manager.patient == null)
            {
                MessageBox.Show("No patient Chosen...");
            }
            else
            {
                Problem problem = new Problem(comboBox3.Text)
                {
                    ProblemNotes = richTextBox1.Text.Trim(),
                    ProblemLocation = comboBox1.Text.Trim() + ' ' + comboBox2.Text.Trim(),
                    
                };
                if (radioButton1.Checked)
                {
                    problem.priority = "Low";

                }
                else if (radioButton2.Checked)
                {
                    problem.priority = "Medium";
                }
                else
                {
                    problem.priority = "High";
                }
                var pln = Plans.Find(x => x.TreatmentPlanName == comboBox4.Text);
                problem.TreatmentPlan = pln;
                Manager.visitDetails.AddProblem(problem.Id);
                Manager.visitDetails.AddDiagnosis(problem.ProblemDiagnosis);
                Manager.patient.Record.AddProblem(problem);
                // await Manager.databaseManager.AddPatient(Manager.patient);
            }
            this.Parent.Parent.Dispose();
        }

        private async void AddProblem_Load(object sender, EventArgs e)
        {
            var treatments = await Manager.databaseManager.GetAllTreatmentplans();
            Plans = treatments;
            foreach (TreatmentPlan treatment in treatments)
            {

                comboBox4.Items.Add(treatment.TreatmentPlanName);
            }


        }
    }
}
