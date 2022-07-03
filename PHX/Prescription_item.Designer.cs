namespace PHX
{
    partial class Prescription_item
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
            this.namelbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.amtlbl = new System.Windows.Forms.Label();
            this.qntlbl = new System.Windows.Forms.Label();
            this.unitlbl = new System.Windows.Forms.Label();
            this.nolbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.namelbl.Location = new System.Drawing.Point(51, 4);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(58, 23);
            this.namelbl.TabIndex = 35;
            this.namelbl.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(5, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(630, 23);
            this.label15.TabIndex = 34;
            this.label15.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------";
            // 
            // amtlbl
            // 
            this.amtlbl.AutoSize = true;
            this.amtlbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.amtlbl.Location = new System.Drawing.Point(572, 4);
            this.amtlbl.Name = "amtlbl";
            this.amtlbl.Size = new System.Drawing.Size(43, 23);
            this.amtlbl.TabIndex = 33;
            this.amtlbl.Text = "Amt";
            // 
            // qntlbl
            // 
            this.qntlbl.AutoSize = true;
            this.qntlbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qntlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.qntlbl.Location = new System.Drawing.Point(479, 4);
            this.qntlbl.Name = "qntlbl";
            this.qntlbl.Size = new System.Drawing.Size(39, 23);
            this.qntlbl.TabIndex = 32;
            this.qntlbl.Text = "Qnt";
            // 
            // unitlbl
            // 
            this.unitlbl.AutoSize = true;
            this.unitlbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unitlbl.Location = new System.Drawing.Point(380, 4);
            this.unitlbl.Name = "unitlbl";
            this.unitlbl.Size = new System.Drawing.Size(42, 23);
            this.unitlbl.TabIndex = 31;
            this.unitlbl.Text = "Unit";
            // 
            // nolbl
            // 
            this.nolbl.AutoSize = true;
            this.nolbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nolbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nolbl.Location = new System.Drawing.Point(5, 4);
            this.nolbl.Name = "nolbl";
            this.nolbl.Size = new System.Drawing.Size(21, 23);
            this.nolbl.TabIndex = 30;
            this.nolbl.Text = "#";
            // 
            // Prescription_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.amtlbl);
            this.Controls.Add(this.qntlbl);
            this.Controls.Add(this.unitlbl);
            this.Controls.Add(this.nolbl);
            this.Name = "Prescription_item";
            this.Size = new System.Drawing.Size(664, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label amtlbl;
        private System.Windows.Forms.Label qntlbl;
        private System.Windows.Forms.Label unitlbl;
        private System.Windows.Forms.Label nolbl;
    }
}
