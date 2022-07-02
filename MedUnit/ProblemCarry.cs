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
    public partial class ProblemCarry : Form
    {
        public ProblemCarry()
        {
            InitializeComponent();
        }

        private void ProblemCarry_Load(object sender, EventArgs e)
        {
            AddProblem addProblem = new AddProblem();
            Content.Controls.Add(addProblem);
        }
    }
}
