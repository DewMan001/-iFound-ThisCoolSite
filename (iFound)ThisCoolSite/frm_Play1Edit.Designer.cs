namespace _iFound_ThisCoolSite
{
    partial class frm_Play1Edit
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
            this.btn_Play1Save = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Play1Save
            // 
            this.btn_Play1Save.Location = new System.Drawing.Point(607, 260);
            this.btn_Play1Save.Name = "btn_Play1Save";
            this.btn_Play1Save.Size = new System.Drawing.Size(115, 47);
            this.btn_Play1Save.TabIndex = 0;
            this.btn_Play1Save.Text = "Save";
            this.btn_Play1Save.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 200);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(710, 26);
            this.numericUpDown1.TabIndex = 1;
            // 
            // frm_Play1Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 319);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_Play1Save);
            this.Name = "frm_Play1Edit";
            this.Text = "frm_Play1Edit";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Play1Save;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}