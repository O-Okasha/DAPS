namespace MedUnit
{
    partial class MedicalUnitMain
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
            this.DataPanel = new System.Windows.Forms.Panel();
            this.bar = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DataPanel
            // 
            this.DataPanel.AutoScroll = true;
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(1421, 167);
            this.DataPanel.TabIndex = 0;
            // 
            // bar
            // 
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(0, 167);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1421, 64);
            this.bar.TabIndex = 1;
            // 
            // Content
            // 
            this.Content.AutoScroll = true;
            this.Content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Content.Location = new System.Drawing.Point(0, 237);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1421, 477);
            this.Content.TabIndex = 2;
            // 
            // MedicalUnitMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1421, 714);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.DataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicalUnitMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Panel Content;
    }
}

