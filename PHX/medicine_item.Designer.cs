namespace PHX
{
    partial class medicine_item
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
            this.ItemNamelbl = new System.Windows.Forms.Label();
            this.ItemBatchNolbl = new System.Windows.Forms.Label();
            this.ItemShelf = new System.Windows.Forms.Label();
            this.ItemSellingPricelbl = new System.Windows.Forms.Label();
            this.ItemBuyingPricelbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemNamelbl
            // 
            this.ItemNamelbl.AutoSize = true;
            this.ItemNamelbl.Location = new System.Drawing.Point(18, 14);
            this.ItemNamelbl.Name = "ItemNamelbl";
            this.ItemNamelbl.Size = new System.Drawing.Size(41, 16);
            this.ItemNamelbl.TabIndex = 0;
            this.ItemNamelbl.Text = "name";
            // 
            // ItemBatchNolbl
            // 
            this.ItemBatchNolbl.AutoSize = true;
            this.ItemBatchNolbl.Location = new System.Drawing.Point(86, 14);
            this.ItemBatchNolbl.Name = "ItemBatchNolbl";
            this.ItemBatchNolbl.Size = new System.Drawing.Size(58, 16);
            this.ItemBatchNolbl.TabIndex = 1;
            this.ItemBatchNolbl.Text = "batch no";
            // 
            // ItemShelf
            // 
            this.ItemShelf.AutoSize = true;
            this.ItemShelf.Location = new System.Drawing.Point(292, 14);
            this.ItemShelf.Name = "ItemShelf";
            this.ItemShelf.Size = new System.Drawing.Size(37, 16);
            this.ItemShelf.TabIndex = 2;
            this.ItemShelf.Text = "Shelf";
            // 
            // ItemSellingPricelbl
            // 
            this.ItemSellingPricelbl.AutoSize = true;
            this.ItemSellingPricelbl.Location = new System.Drawing.Point(710, 14);
            this.ItemSellingPricelbl.Name = "ItemSellingPricelbl";
            this.ItemSellingPricelbl.Size = new System.Drawing.Size(82, 16);
            this.ItemSellingPricelbl.TabIndex = 3;
            this.ItemSellingPricelbl.Text = "Selling Price";
            // 
            // ItemBuyingPricelbl
            // 
            this.ItemBuyingPricelbl.AutoSize = true;
            this.ItemBuyingPricelbl.Location = new System.Drawing.Point(497, 14);
            this.ItemBuyingPricelbl.Name = "ItemBuyingPricelbl";
            this.ItemBuyingPricelbl.Size = new System.Drawing.Size(82, 16);
            this.ItemBuyingPricelbl.TabIndex = 4;
            this.ItemBuyingPricelbl.Text = "Buying Price";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = true;
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(973, 11);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 28);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // medicine_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ItemBuyingPricelbl);
            this.Controls.Add(this.ItemSellingPricelbl);
            this.Controls.Add(this.ItemShelf);
            this.Controls.Add(this.ItemBatchNolbl);
            this.Controls.Add(this.ItemNamelbl);
            this.Name = "medicine_item";
            this.Size = new System.Drawing.Size(1079, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemNamelbl;
        private System.Windows.Forms.Label ItemBatchNolbl;
        private System.Windows.Forms.Label ItemShelf;
        private System.Windows.Forms.Label ItemSellingPricelbl;
        private System.Windows.Forms.Label ItemBuyingPricelbl;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
