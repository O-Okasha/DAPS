namespace DAPS
{
    partial class EventForm
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
            this.textdate = new System.Windows.Forms.TextBox();
            this.textevent = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.Event = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textdate
            // 
            this.textdate.Enabled = false;
            this.textdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdate.Location = new System.Drawing.Point(86, 60);
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(272, 30);
            this.textdate.TabIndex = 0;
            // 
            // textevent
            // 
            this.textevent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textevent.Location = new System.Drawing.Point(86, 148);
            this.textevent.Name = "textevent";
            this.textevent.Size = new System.Drawing.Size(272, 30);
            this.textevent.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(98, 41);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 16);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            // 
            // Event
            // 
            this.Event.AutoSize = true;
            this.Event.Location = new System.Drawing.Point(98, 129);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(41, 16);
            this.Event.TabIndex = 1;
            this.Event.Text = "Event";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(283, 214);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 268);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.textevent);
            this.Controls.Add(this.textdate);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textdate;
        private System.Windows.Forms.TextBox textevent;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Event;
        private System.Windows.Forms.Button save;
    }
}