namespace MedUnit
{
    partial class PrescribedMedControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this._class = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.Label();
            this.dose = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(167, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(349, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 42);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(543, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 42);
            this.panel3.TabIndex = 0;
            // 
            // _class
            // 
            this._class.AutoSize = true;
            this._class.Location = new System.Drawing.Point(174, 17);
            this._class.Name = "_class";
            this._class.Size = new System.Drawing.Size(44, 16);
            this._class.TabIndex = 1;
            this._class.Text = "label1";
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Location = new System.Drawing.Point(3, 17);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(44, 16);
            this.active.TabIndex = 2;
            this.active.Text = "label2";
            // 
            // dose
            // 
            this.dose.AutoSize = true;
            this.dose.Location = new System.Drawing.Point(356, 17);
            this.dose.Name = "dose";
            this.dose.Size = new System.Drawing.Size(44, 16);
            this.dose.TabIndex = 1;
            this.dose.Text = "label1";
            // 
            // remove
            // 
            this.remove.Dock = System.Windows.Forms.DockStyle.Right;
            this.remove.FlatAppearance.BorderSize = 0;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Location = new System.Drawing.Point(550, 0);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(159, 47);
            this.remove.TabIndex = 3;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // PrescribedMedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.remove);
            this.Controls.Add(this.active);
            this.Controls.Add(this.dose);
            this.Controls.Add(this._class);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PrescribedMedControl";
            this.Size = new System.Drawing.Size(709, 47);
            this.Load += new System.EventHandler(this.PrescribedMedControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label _class;
        private System.Windows.Forms.Label active;
        private System.Windows.Forms.Label dose;
        private System.Windows.Forms.Button remove;
    }
}
