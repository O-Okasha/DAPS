﻿using System;
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
    public partial class Medicine_Page : UserControl
    {
        public Medicine_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls[0].Controls.Clear();
            New_Med_page new_Med_Page = new New_Med_page();
            this.Parent.Controls[0].Controls.Add(new_Med_Page);
        }
    }
}
