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
            this.Servies = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.serv = new System.Windows.Forms.Label();
            this.Pri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Servies
            // 
            this.Servies.AutoSize = true;
            this.Servies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servies.Location = new System.Drawing.Point(3, 10);
            this.Servies.Name = "Servies";
            this.Servies.Size = new System.Drawing.Size(78, 25);
            this.Servies.TabIndex = 0;
            this.Servies.Text = "Servies";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(198, 10);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(56, 25);
            this.Price.TabIndex = 1;
            this.Price.Text = "Price";
            // 
            // serv
            // 
            this.serv.AutoSize = true;
            this.serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serv.Location = new System.Drawing.Point(80, 10);
            this.serv.Name = "serv";
            this.serv.Size = new System.Drawing.Size(53, 25);
            this.serv.TabIndex = 2;
            this.serv.Text = "Serv";
            // 
            // Pri
            // 
            this.Pri.AutoSize = true;
            this.Pri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pri.Location = new System.Drawing.Point(274, 10);
            this.Pri.Name = "Pri";
            this.Pri.Size = new System.Drawing.Size(35, 25);
            this.Pri.TabIndex = 3;
            this.Pri.Text = "Pri";
            // 
            // PaymentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pri);
            this.Controls.Add(this.serv);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Servies);
            this.Name = "PaymentUserControl";
            this.Size = new System.Drawing.Size(362, 55);
            this.Load += new System.EventHandler(this.PaymentUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Servies;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label serv;
        private System.Windows.Forms.Label Pri;
    }
}
