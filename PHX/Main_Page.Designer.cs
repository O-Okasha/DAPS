
namespace PHX
{
    partial class Main_Page
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
            this.LogoAcc_bar = new System.Windows.Forms.Panel();
            this.Side_Bar = new System.Windows.Forms.Panel();
            this.MainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LogoAcc_bar
            // 
            this.LogoAcc_bar.Location = new System.Drawing.Point(-1, 0);
            this.LogoAcc_bar.Name = "LogoAcc_bar";
            this.LogoAcc_bar.Size = new System.Drawing.Size(1442, 66);
            this.LogoAcc_bar.TabIndex = 0;
            this.LogoAcc_bar.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoAcc_bar_Paint);
            // 
            // Side_Bar
            // 
            this.Side_Bar.Location = new System.Drawing.Point(-1, 67);
            this.Side_Bar.Name = "Side_Bar";
            this.Side_Bar.Size = new System.Drawing.Size(203, 695);
            this.Side_Bar.TabIndex = 1;
            this.Side_Bar.Paint += new System.Windows.Forms.PaintEventHandler(this.Side_Bar_Paint);
            // 
            // MainContainer
            // 
            this.MainContainer.AutoScrollMargin = new System.Drawing.Size(0, 300);
            this.MainContainer.AutoScrollMinSize = new System.Drawing.Size(0, 300);
            this.MainContainer.Location = new System.Drawing.Point(203, 67);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(1238, 695);
            this.MainContainer.TabIndex = 3;
            this.MainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MainContainer_Paint);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1439, 761);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.Side_Bar);
            this.Controls.Add(this.LogoAcc_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Page";
            this.Load += new System.EventHandler(this.Login_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoAcc_bar;
        private System.Windows.Forms.Panel Side_Bar;
        private System.Windows.Forms.FlowLayoutPanel MainContainer;
    }
}

