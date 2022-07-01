namespace PHX
{
    partial class Shelf_item
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
            this.Item_name = new System.Windows.Forms.Label();
            this.Numeric_no_item = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Item_name
            // 
            this.Item_name.AutoSize = true;
            this.Item_name.Location = new System.Drawing.Point(30, 24);
            this.Item_name.Name = "Item_name";
            this.Item_name.Size = new System.Drawing.Size(44, 16);
            this.Item_name.TabIndex = 0;
            this.Item_name.Text = "Name";
            this.Item_name.Click += new System.EventHandler(this.Item_name_Click);
            // 
            // Numeric_no_item
            // 
            this.Numeric_no_item.AutoSize = true;
            this.Numeric_no_item.Location = new System.Drawing.Point(232, 24);
            this.Numeric_no_item.Name = "Numeric_no_item";
            this.Numeric_no_item.Size = new System.Drawing.Size(108, 16);
            this.Numeric_no_item.TabIndex = 1;
            this.Numeric_no_item.Text = "Numeric Number";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(454, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shelf_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Numeric_no_item);
            this.Controls.Add(this.Item_name);
            this.Name = "Shelf_item";
            this.Size = new System.Drawing.Size(552, 62);
            this.Load += new System.EventHandler(this.Shelf_item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Item_name;
        private System.Windows.Forms.Label Numeric_no_item;
        private System.Windows.Forms.Button button1;
    }
}
