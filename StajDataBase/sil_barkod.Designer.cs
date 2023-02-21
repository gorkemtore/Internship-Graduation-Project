namespace StajDataBase
{
    partial class sil_barkod
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
            this.txt_barkodSil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_barkodSil
            // 
            this.txt_barkodSil.Location = new System.Drawing.Point(149, 39);
            this.txt_barkodSil.Name = "txt_barkodSil";
            this.txt_barkodSil.Size = new System.Drawing.Size(100, 20);
            this.txt_barkodSil.TabIndex = 0;
            this.txt_barkodSil.TextChanged += new System.EventHandler(this.Txt_barkodSil_TextChanged);
            this.txt_barkodSil.Enter += new System.EventHandler(this.Txt_barkodSil_Enter);
            this.txt_barkodSil.MouseEnter += new System.EventHandler(this.Txt_barkodSil_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BARKOD NUMARASI:";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(174, 70);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // sil_barkod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 105);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_barkodSil);
            this.Name = "sil_barkod";
            this.Text = "sil_barkod";
            this.Enter += new System.EventHandler(this.Sil_barkod_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_barkodSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sil;
    }
}