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
    public partial class ProblemControl : UserControl
    {
        Problem problem;
        public ProblemControl(Problem prob)
        {
            InitializeComponent();
            problem = prob;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.ChangeProblem(problem);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProblemControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = problem.ProblemDiagnosis;
        }
    }
}
