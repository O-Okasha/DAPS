namespace PHX
{
    partial class Purchase_item
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
            this.PCodelbl = new System.Windows.Forms.Label();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.GrandTlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.PaymentMlbl = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PCodelbl
            // 
            this.PCodelbl.AutoSize = true;
            this.PCodelbl.BackColor = System.Drawing.Color.White;
            this.PCodelbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCodelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PCodelbl.Location = new System.Drawing.Point(15, 11);
            this.PCodelbl.Name = "PCodelbl";
            this.PCodelbl.Size = new System.Drawing.Size(127, 23);
            this.PCodelbl.TabIndex = 18;
            this.PCodelbl.Text = "Purchase Code";
            this.PCodelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.BackColor = System.Drawing.Color.White;
            this.Statuslbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Statuslbl.Location = new System.Drawing.Point(824, 11);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(58, 23);
            this.Statuslbl.TabIndex = 23;
            this.Statuslbl.Text = "Status";
            // 
            // GrandTlbl
            // 
            this.GrandTlbl.AutoSize = true;
            this.GrandTlbl.BackColor = System.Drawing.Color.White;
            this.GrandTlbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GrandTlbl.Location = new System.Drawing.Point(640, 11);
            this.GrandTlbl.Name = "GrandTlbl";
            this.GrandTlbl.Size = new System.Drawing.Size(100, 23);
            this.GrandTlbl.TabIndex = 20;
            this.GrandTlbl.Text = "Grand Total";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.BackColor = System.Drawing.Color.White;
            this.Namelbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Namelbl.Location = new System.Drawing.Point(275, 11);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(58, 23);
            this.Namelbl.TabIndex = 21;
            this.Namelbl.Text = "Name";
            // 
            // PaymentMlbl
            // 
            this.PaymentMlbl.AutoSize = true;
            this.PaymentMlbl.BackColor = System.Drawing.Color.White;
            this.PaymentMlbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PaymentMlbl.Location = new System.Drawing.Point(424, 11);
            this.PaymentMlbl.Name = "PaymentMlbl";
            this.PaymentMlbl.Size = new System.Drawing.Size(145, 23);
            this.PaymentMlbl.TabIndex = 22;
            this.PaymentMlbl.Text = "Payment Method";
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(1030, 13);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 29);
            this.Deletebtn.TabIndex = 25;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Purchase_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.PaymentMlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.GrandTlbl);
            this.Controls.Add(this.PCodelbl);
            this.Name = "Purchase_item";
            this.Size = new System.Drawing.Size(1117, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PCodelbl;
        private System.Windows.Forms.Label Statuslbl;
        private System.Windows.Forms.Label GrandTlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label PaymentMlbl;
        private System.Windows.Forms.Button Deletebtn;
    }
}
