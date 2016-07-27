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
            this.btn_P1Save = new System.Windows.Forms.Button();
            this.numUpDown_P1EditWallet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_P1EditName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_P1EditWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_P1Save
            // 
            this.btn_P1Save.Location = new System.Drawing.Point(459, 195);
            this.btn_P1Save.Name = "btn_P1Save";
            this.btn_P1Save.Size = new System.Drawing.Size(115, 47);
            this.btn_P1Save.TabIndex = 0;
            this.btn_P1Save.Text = "Save";
            this.btn_P1Save.UseVisualStyleBackColor = true;
            this.btn_P1Save.Click += new System.EventHandler(this.btn_P1Save_Click);
            // 
            // numUpDown_P1EditWallet
            // 
            this.numUpDown_P1EditWallet.Location = new System.Drawing.Point(12, 143);
            this.numUpDown_P1EditWallet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDown_P1EditWallet.Name = "numUpDown_P1EditWallet";
            this.numUpDown_P1EditWallet.Size = new System.Drawing.Size(562, 26);
            this.numUpDown_P1EditWallet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wallet";
            // 
            // txt_P1EditName
            // 
            this.txt_P1EditName.Location = new System.Drawing.Point(12, 75);
            this.txt_P1EditName.Name = "txt_P1EditName";
            this.txt_P1EditName.Size = new System.Drawing.Size(562, 26);
            this.txt_P1EditName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // frm_Play1Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_P1EditName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDown_P1EditWallet);
            this.Controls.Add(this.btn_P1Save);
            this.Name = "frm_Play1Edit";
            this.Text = "frm_Play1Edit";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_P1EditWallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_P1Save;
        private System.Windows.Forms.NumericUpDown numUpDown_P1EditWallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_P1EditName;
        private System.Windows.Forms.Label label2;
    }
}