namespace PHX
{
    partial class List_item
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
            this.Namelbl = new System.Windows.Forms.Label();
            this.Amtlbl = new System.Windows.Forms.Label();
            this.Qntlbl = new System.Windows.Forms.Label();
            this.Unitlbl = new System.Windows.Forms.Label();
            this.Nolbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Namelbl.Location = new System.Drawing.Point(58, 8);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(58, 23);
            this.Namelbl.TabIndex = 12;
            this.Namelbl.Text = "Name";
            // 
            // Amtlbl
            // 
            this.Amtlbl.AutoSize = true;
            this.Amtlbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amtlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Amtlbl.Location = new System.Drawing.Point(579, 8);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(43, 23);
            this.Amtlbl.TabIndex = 11;
            this.Amtlbl.Text = "Amt";
            // 
            // Qntlbl
            // 
            this.Qntlbl.AutoSize = true;
            this.Qntlbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qntlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Qntlbl.Location = new System.Drawing.Point(486, 8);
            this.Qntlbl.Name = "Qntlbl";
            this.Qntlbl.Size = new System.Drawing.Size(39, 23);
            this.Qntlbl.TabIndex = 10;
            this.Qntlbl.Text = "Qnt";
            // 
            // Unitlbl
            // 
            this.Unitlbl.AutoSize = true;
            this.Unitlbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unitlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Unitlbl.Location = new System.Drawing.Point(387, 8);
            this.Unitlbl.Name = "Unitlbl";
            this.Unitlbl.Size = new System.Drawing.Size(42, 23);
            this.Unitlbl.TabIndex = 9;
            this.Unitlbl.Text = "Unit";
            // 
            // Nolbl
            // 
            this.Nolbl.AutoSize = true;
            this.Nolbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nolbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Nolbl.Location = new System.Drawing.Point(12, 8);
            this.Nolbl.Name = "Nolbl";
            this.Nolbl.Size = new System.Drawing.Size(21, 23);
            this.Nolbl.TabIndex = 8;
            this.Nolbl.Text = "#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------";
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Location = new System.Drawing.Point(641, 8);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(28, 23);
            this.Deletebtn.TabIndex = 14;
            this.Deletebtn.Text = "D";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // List_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Amtlbl);
            this.Controls.Add(this.Qntlbl);
            this.Controls.Add(this.Unitlbl);
            this.Controls.Add(this.Nolbl);
            this.Name = "List_item";
            this.Size = new System.Drawing.Size(672, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Amtlbl;
        private System.Windows.Forms.Label Qntlbl;
        private System.Windows.Forms.Label Unitlbl;
        private System.Windows.Forms.Label Nolbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deletebtn;
    }
}
