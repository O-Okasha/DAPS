
namespace PHX
{
    partial class Login_control
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
            this.LoginBar = new System.Windows.Forms.Panel();
            this.Login_label = new System.Windows.Forms.Label();
            this.Email_txtbox = new System.Windows.Forms.TextBox();
            this.Pass_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.LoginBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBar
            // 
            this.LoginBar.BackColor = System.Drawing.Color.Navy;
            this.LoginBar.Controls.Add(this.Login_label);
            this.LoginBar.Location = new System.Drawing.Point(0, 0);
            this.LoginBar.Name = "LoginBar";
            this.LoginBar.Size = new System.Drawing.Size(400, 73);
            this.LoginBar.TabIndex = 0;
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_label.ForeColor = System.Drawing.Color.White;
            this.Login_label.Location = new System.Drawing.Point(98, 24);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(209, 33);
            this.Login_label.TabIndex = 1;
            this.Login_label.Text = "Log In Pharmplus";
            // 
            // Email_txtbox
            // 
            this.Email_txtbox.Location = new System.Drawing.Point(59, 125);
            this.Email_txtbox.Name = "Email_txtbox";
            this.Email_txtbox.Size = new System.Drawing.Size(270, 22);
            this.Email_txtbox.TabIndex = 1;
            // 
            // Pass_txtbox
            // 
            this.Pass_txtbox.Location = new System.Drawing.Point(59, 166);
            this.Pass_txtbox.Name = "Pass_txtbox";
            this.Pass_txtbox.Size = new System.Drawing.Size(270, 22);
            this.Pass_txtbox.TabIndex = 2;
            this.Pass_txtbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.Navy;
            this.Login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(247, 216);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(82, 28);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "Log in";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Login_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Pass_txtbox);
            this.Controls.Add(this.Email_txtbox);
            this.Controls.Add(this.LoginBar);
            this.Name = "Login_control";
            this.Size = new System.Drawing.Size(400, 290);
            this.LoginBar.ResumeLayout(false);
            this.LoginBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginBar;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.TextBox Email_txtbox;
        private System.Windows.Forms.MaskedTextBox Pass_txtbox;
        private System.Windows.Forms.Button Login_btn;
    }
}
