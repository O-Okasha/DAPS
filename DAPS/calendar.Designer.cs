namespace DAPS
{
    partial class calendar
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
            this.Friday = new System.Windows.Forms.Label();
            this.Wednesday = new System.Windows.Forms.Label();
            this.Thursday = new System.Windows.Forms.Label();
            this.Tuesday = new System.Windows.Forms.Label();
            this.Monday = new System.Windows.Forms.Label();
            this.Sunday = new System.Windows.Forms.Label();
            this.Saturday = new System.Windows.Forms.Label();
            this.Pervious = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbdate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Friday.Location = new System.Drawing.Point(951, 56);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(66, 25);
            this.Friday.TabIndex = 31;
            this.Friday.Text = "Friday";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wednesday.Location = new System.Drawing.Point(579, 56);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(118, 25);
            this.Wednesday.TabIndex = 30;
            this.Wednesday.Text = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thursday.Location = new System.Drawing.Point(769, 56);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(95, 25);
            this.Thursday.TabIndex = 29;
            this.Thursday.Text = "Thursday";
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuesday.Location = new System.Drawing.Point(422, 56);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(89, 25);
            this.Tuesday.TabIndex = 28;
            this.Tuesday.Text = "Tuesday";
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday.Location = new System.Drawing.Point(240, 56);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(83, 25);
            this.Monday.TabIndex = 27;
            this.Monday.Text = "Monday";
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunday.Location = new System.Drawing.Point(62, 56);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(80, 25);
            this.Sunday.TabIndex = 26;
            this.Sunday.Text = "Sunday";
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saturday.Location = new System.Drawing.Point(1116, 56);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(91, 25);
            this.Saturday.TabIndex = 25;
            this.Saturday.Text = "Saturday";
            // 
            // Pervious
            // 
            this.Pervious.Location = new System.Drawing.Point(956, 606);
            this.Pervious.Name = "Pervious";
            this.Pervious.Size = new System.Drawing.Size(126, 23);
            this.Pervious.TabIndex = 24;
            this.Pervious.Text = "Pervious";
            this.Pervious.UseVisualStyleBackColor = true;
            this.Pervious.Click += new System.EventHandler(this.Pervious_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(1121, 606);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(126, 23);
            this.Next.TabIndex = 23;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1236, 516);
            this.flowLayoutPanel1.TabIndex = 32;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lbdate
            // 
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(491, 5);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(253, 36);
            this.lbdate.TabIndex = 33;
            this.lbdate.Text = "MONTH YEAR";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbdate.Click += new System.EventHandler(this.lbdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(527, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 10);
            this.panel1.TabIndex = 34;
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Pervious);
            this.Controls.Add(this.Next);
            this.Name = "calendar";
            this.Size = new System.Drawing.Size(1357, 635);
            this.Load += new System.EventHandler(this.calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label Sunday;
        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.Button Pervious;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Panel panel1;
    }
}