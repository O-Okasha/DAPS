namespace MedUnit
{
    partial class ProcedureControl
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
            this.procedureName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // procedureName
            // 
            this.procedureName.AutoSize = true;
            this.procedureName.Location = new System.Drawing.Point(8, 5);
            this.procedureName.Name = "procedureName";
            this.procedureName.Size = new System.Drawing.Size(44, 16);
            this.procedureName.TabIndex = 0;
            this.procedureName.Text = "label1";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(364, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(261, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add with notes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProcedureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.procedureName);
            this.Name = "ProcedureControl";
            this.Size = new System.Drawing.Size(439, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label procedureName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
