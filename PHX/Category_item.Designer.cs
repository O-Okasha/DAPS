namespace PHX
{
    partial class Category_item
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
            this.namelbl = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(25, 25);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(41, 16);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "name";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Location = new System.Drawing.Point(244, 25);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(73, 16);
            this.desclbl.TabIndex = 1;
            this.desclbl.Text = "description";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(435, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.namelbl);
            this.Name = "Category_item";
            this.Size = new System.Drawing.Size(552, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Button button1;
    }
}
