namespace PHX
{
    partial class Supplier_item
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
            this.Itememaillbl = new System.Windows.Forms.Label();
            this.ItemPhonelbl = new System.Windows.Forms.Label();
            this.ItemNamelbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Itememaillbl
            // 
            this.Itememaillbl.AutoSize = true;
            this.Itememaillbl.BackColor = System.Drawing.Color.White;
            this.Itememaillbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itememaillbl.ForeColor = System.Drawing.Color.Black;
            this.Itememaillbl.Location = new System.Drawing.Point(296, 11);
            this.Itememaillbl.Name = "Itememaillbl";
            this.Itememaillbl.Size = new System.Drawing.Size(52, 23);
            this.Itememaillbl.TabIndex = 12;
            this.Itememaillbl.Text = "Email";
            // 
            // ItemPhonelbl
            // 
            this.ItemPhonelbl.AutoSize = true;
            this.ItemPhonelbl.BackColor = System.Drawing.Color.White;
            this.ItemPhonelbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPhonelbl.ForeColor = System.Drawing.Color.Black;
            this.ItemPhonelbl.Location = new System.Drawing.Point(661, 11);
            this.ItemPhonelbl.Name = "ItemPhonelbl";
            this.ItemPhonelbl.Size = new System.Drawing.Size(60, 23);
            this.ItemPhonelbl.TabIndex = 11;
            this.ItemPhonelbl.Text = "Phone";
            // 
            // ItemNamelbl
            // 
            this.ItemNamelbl.AutoSize = true;
            this.ItemNamelbl.BackColor = System.Drawing.Color.White;
            this.ItemNamelbl.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNamelbl.ForeColor = System.Drawing.Color.Black;
            this.ItemNamelbl.Location = new System.Drawing.Point(36, 11);
            this.ItemNamelbl.Name = "ItemNamelbl";
            this.ItemNamelbl.Size = new System.Drawing.Size(58, 23);
            this.ItemNamelbl.TabIndex = 9;
            this.ItemNamelbl.Text = "Name";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = true;
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(988, 10);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 28);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Supplier_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Itememaillbl);
            this.Controls.Add(this.ItemPhonelbl);
            this.Controls.Add(this.ItemNamelbl);
            this.Name = "Supplier_item";
            this.Size = new System.Drawing.Size(1079, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Itememaillbl;
        private System.Windows.Forms.Label ItemPhonelbl;
        private System.Windows.Forms.Label ItemNamelbl;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
