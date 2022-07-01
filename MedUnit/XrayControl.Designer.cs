namespace MedUnit
{
    partial class XrayControl
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
            this.textName = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Location = new System.Drawing.Point(6, 8);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(44, 16);
            this.textName.TabIndex = 0;
            this.textName.Text = "label1";
            // 
            // textDate
            // 
            this.textDate.AutoSize = true;
            this.textDate.Location = new System.Drawing.Point(237, 8);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(44, 16);
            this.textDate.TabIndex = 0;
            this.textDate.Text = "label1";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(456, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // XrayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textName);
            this.Name = "XrayControl";
            this.Size = new System.Drawing.Size(531, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Label textDate;
        private System.Windows.Forms.Button button1;
    }
}
