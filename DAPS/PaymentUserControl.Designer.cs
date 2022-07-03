namespace DAPS
{
    partial class PaymentUserControl
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
            this.Price = new System.Windows.Forms.Label();
            this.Pri = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(3, 10);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(62, 25);
            this.Price.TabIndex = 1;
            this.Price.Text = "Total:";
            // 
            // Pri
            // 
            this.Pri.AutoSize = true;
            this.Pri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pri.Location = new System.Drawing.Point(79, 10);
            this.Pri.Name = "Pri";
            this.Pri.Size = new System.Drawing.Size(35, 25);
            this.Pri.TabIndex = 3;
            this.Pri.Text = "Pri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pri);
            this.Controls.Add(this.Price);
            this.Name = "PaymentUserControl";
            this.Size = new System.Drawing.Size(362, 55);
            this.Load += new System.EventHandler(this.PaymentUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Pri;
        private System.Windows.Forms.Button button1;
    }
}
