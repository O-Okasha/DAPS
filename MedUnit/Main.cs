using MedUnit.Models;
using System;
using System.Windows.Forms;

namespace MedUnit
{
    public partial class Main : UserControl
    {
        Problem CurrProblem;
        TreatmentPlan CurrTreatmentPlan;

        public Main()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProblemCarry problemCarry = new ProblemCarry();
            problemCarry.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddTreatment addTreatment = new AddTreatment();
            addTreatment.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Prescriptions prescriptions = new Prescriptions();
            prescriptions.ShowDialog();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (Manager.patient != null)
                {
                    flowLayoutPanel3.Controls.Clear();
                    foreach (Problem p in Manager.patient.Record.Problems)
                    {
                        ProblemControl problemControl = new ProblemControl(p);
                        flowLayoutPanel3.Controls.Add(problemControl);
                    }
                    if (Manager.ActiveProblem != null)
                    {
                        CurrProblem = Manager.ActiveProblem;
                        richTextBox1.Text = CurrProblem.ProblemLocation + ", " + CurrProblem.ProblemDiagnosis + ", " + CurrProblem.priority;
                        richTextBox2.Text = CurrProblem.ProblemNotes;
                        CurrTreatmentPlan = CurrProblem.TreatmentPlan;
                        flowLayoutPanel1.Controls.Clear();
                        TreatmentplanControl control = new TreatmentplanControl(CurrTreatmentPlan);
                        flowLayoutPanel1.Controls.Add(control);
                        flowLayoutPanel2.Controls.Clear();
                        foreach (Service ser in Manager.ActivePlan.services)
                        {
                            ServiceControl serviceControl = new ServiceControl(ser);
                            flowLayoutPanel2.Controls.Add(serviceControl);
                        }

                    }
                }

            }
            catch (Exception ex)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.SaveAll();
        }
    }
}
