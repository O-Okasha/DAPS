namespace DAPS
{
    partial class TotalUserControl
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
            this.Total = new System.Windows.Forms.Label();
            this.Tot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(30, 15);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(56, 25);
            this.Total.TabIndex = 0;
            this.Total.Text = "Total";
            // 
            // Tot
            // 
            this.Tot.AutoSize = true;
            this.Tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tot.Location = new System.Drawing.Point(206, 15);
            this.Tot.Name = "Tot";
            this.Tot.Size = new System.Drawing.Size(41, 25);
            this.Tot.TabIndex = 1;
            this.Tot.Text = "Tot";
            // 
            // TotalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tot);
            this.Controls.Add(this.Total);
            this.Name = "TotalUserControl";
            this.Size = new System.Drawing.Size(362, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Tot;
    }
}
