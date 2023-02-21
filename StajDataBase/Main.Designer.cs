namespace StajDataBase
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_pulver = new System.Windows.Forms.Button();
            this.btn_elastron = new System.Windows.Forms.Button();
            this.button_conta = new System.Windows.Forms.Button();
            this.btn_pec = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(1233, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(106, 44);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.GridColor = System.Drawing.Color.Gray;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1386, 649);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick_1);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentDoubleClick);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(1121, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(106, 44);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // btn_pulver
            // 
            this.btn_pulver.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_pulver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pulver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pulver.Location = new System.Drawing.Point(410, 22);
            this.btn_pulver.Name = "btn_pulver";
            this.btn_pulver.Size = new System.Drawing.Size(117, 44);
            this.btn_pulver.TabIndex = 5;
            this.btn_pulver.Text = "PULVER";
            this.btn_pulver.UseVisualStyleBackColor = false;
            this.btn_pulver.Click += new System.EventHandler(this.Btn_pulver_Click);
            // 
            // btn_elastron
            // 
            this.btn_elastron.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_elastron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elastron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_elastron.Location = new System.Drawing.Point(533, 22);
            this.btn_elastron.Name = "btn_elastron";
            this.btn_elastron.Size = new System.Drawing.Size(117, 44);
            this.btn_elastron.TabIndex = 6;
            this.btn_elastron.Text = "ELASTRON";
            this.btn_elastron.UseVisualStyleBackColor = false;
            this.btn_elastron.Click += new System.EventHandler(this.btn_conta_Click);
            // 
            // button_conta
            // 
            this.button_conta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_conta.Location = new System.Drawing.Point(656, 22);
            this.button_conta.Name = "button_conta";
            this.button_conta.Size = new System.Drawing.Size(117, 44);
            this.button_conta.TabIndex = 7;
            this.button_conta.Text = "CONTA";
            this.button_conta.UseVisualStyleBackColor = false;
            this.button_conta.Click += new System.EventHandler(this.btn_elastron_Click);
            // 
            // btn_pec
            // 
            this.btn_pec.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_pec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pec.Location = new System.Drawing.Point(779, 22);
            this.btn_pec.Name = "btn_pec";
            this.btn_pec.Size = new System.Drawing.Size(117, 44);
            this.btn_pec.TabIndex = 8;
            this.btn_pec.Text = "HEPSİ";
            this.btn_pec.UseVisualStyleBackColor = false;
            this.btn_pec.Click += new System.EventHandler(this.Btn_pec_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.Location = new System.Drawing.Point(12, 14);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(117, 44);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "ÇIKIŞ";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1351, 701);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_pec);
            this.Controls.Add(this.button_conta);
            this.Controls.Add(this.btn_elastron);
            this.Controls.Add(this.btn_pulver);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "GENEL FORM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_pulver;
        private System.Windows.Forms.Button btn_elastron;
        private System.Windows.Forms.Button button_conta;
        private System.Windows.Forms.Button btn_pec;
        private System.Windows.Forms.Button btn_exit;
    }
}

