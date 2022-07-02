namespace DAPS
{
    partial class listviewUserControl
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
            this.Calendar = new System.Windows.Forms.Button();
            this.PaymentInfo = new System.Windows.Forms.Button();
            this.DAPS = new System.Windows.Forms.Label();
            this.addpatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Location = new System.Drawing.Point(3, 144);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(209, 52);
            this.Calendar.TabIndex = 18;
            this.Calendar.Text = "Calendar";
            this.Calendar.UseVisualStyleBackColor = true;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // PaymentInfo
            // 
            this.PaymentInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentInfo.Location = new System.Drawing.Point(3, 86);
            this.PaymentInfo.Name = "PaymentInfo";
            this.PaymentInfo.Size = new System.Drawing.Size(209, 52);
            this.PaymentInfo.TabIndex = 17;
            this.PaymentInfo.Text = "Payment Info";
            this.PaymentInfo.UseVisualStyleBackColor = true;
            this.PaymentInfo.Click += new System.EventHandler(this.PaymentInfo_Click);
            // 
            // DAPS
            // 
            this.DAPS.AutoSize = true;
            this.DAPS.BackColor = System.Drawing.Color.DodgerBlue;
            this.DAPS.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAPS.ForeColor = System.Drawing.SystemColors.Window;
            this.DAPS.Location = new System.Drawing.Point(3, 9);
            this.DAPS.Name = "DAPS";
            this.DAPS.Size = new System.Drawing.Size(184, 74);
            this.DAPS.TabIndex = 20;
            this.DAPS.Text = "DAPS";
            this.DAPS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addpatient
            // 
            this.addpatient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpatient.Location = new System.Drawing.Point(3, 203);
            this.addpatient.Name = "addpatient";
            this.addpatient.Size = new System.Drawing.Size(209, 52);
            this.addpatient.TabIndex = 21;
            this.addpatient.Text = "Add Patient ";
            this.addpatient.UseVisualStyleBackColor = true;
            this.addpatient.Click += new System.EventHandler(this.addpatient_Click);
            // 
            // listviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addpatient);
            this.Controls.Add(this.DAPS);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.PaymentInfo);
            this.Name = "listviewUserControl";
            this.Size = new System.Drawing.Size(215, 593);
            this.Load += new System.EventHandler(this.listviewUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button Calendar;
        protected System.Windows.Forms.Button PaymentInfo;
        private System.Windows.Forms.Label DAPS;
        private System.Windows.Forms.Button addpatient;
    }
}
