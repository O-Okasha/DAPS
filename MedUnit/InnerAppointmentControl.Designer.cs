namespace MedUnit
{
    partial class InnerAppointmentControl
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
            this.richNotes = new System.Windows.Forms.RichTextBox();
            this.Date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richNotes
            // 
            this.richNotes.BackColor = System.Drawing.SystemColors.Control;
            this.richNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richNotes.Enabled = false;
            this.richNotes.Location = new System.Drawing.Point(323, 3);
            this.richNotes.Name = "richNotes";
            this.richNotes.Size = new System.Drawing.Size(309, 96);
            this.richNotes.TabIndex = 0;
            this.richNotes.Text = "";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(14, 37);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(51, 20);
            this.Date.TabIndex = 1;
            this.Date.Text = "label1";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(831, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InnerAppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.richNotes);
            this.Name = "InnerAppointmentControl";
            this.Size = new System.Drawing.Size(1011, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richNotes;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button button1;
    }
}
