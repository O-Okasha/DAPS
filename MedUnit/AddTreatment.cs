﻿using System;
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
    public partial class AddTreatment : Form
    {
        public AddTreatment()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
