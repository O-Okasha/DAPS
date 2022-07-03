namespace DAPS
{
    partial class Payment_Info
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Payment = new System.Windows.Forms.Label();
            this.PatientID = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowpanelservices = new System.Windows.Forms.FlowLayoutPanel();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Payment
            // 
            this.Payment.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Payment.Location = new System.Drawing.Point(6, 2);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(255, 67);
            this.Payment.TabIndex = 4;
            this.Payment.Text = "Payment";
            // 
            // PatientID
            // 
            this.PatientID.AutoSize = true;
            this.PatientID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientID.Location = new System.Drawing.Point(13, 100);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(105, 22);
            this.PatientID.TabIndex = 5;
            this.PatientID.Text = "Patient SSN";
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.Location = new System.Drawing.Point(13, 137);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(115, 22);
            this.PatientName.TabIndex = 6;
            this.PatientName.Text = "Patient Name";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(13, 178);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(42, 22);
            this.Age.TabIndex = 7;
            this.Age.Text = "Age";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(161, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 22);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(161, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(161, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 23;
            // 
            // flowpanelservices
            // 
            this.flowpanelservices.Location = new System.Drawing.Point(734, 100);
            this.flowpanelservices.Name = "flowpanelservices";
            this.flowpanelservices.Size = new System.Drawing.Size(362, 340);
            this.flowpanelservices.TabIndex = 3;
            this.flowpanelservices.Paint += new System.Windows.Forms.PaintEventHandler(this.flowpanelservices_Paint);
            // 
            // Submitbtn
            // 
            this.Submitbtn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbtn.Location = new System.Drawing.Point(17, 232);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 29;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(16, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 10);
            this.panel1.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1021, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Payment_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.flowpanelservices);
            this.Name = "Payment_Info";
            this.Size = new System.Drawing.Size(1357, 635);
            this.Load += new System.EventHandler(this.PaymentInfoDental_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Label PatientID;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowpanelservices;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}