namespace SınavSistemi.Ogrenci
{
    partial class Ogrenci_SinavOl
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.grp_soru = new System.Windows.Forms.GroupBox();
            this.rdb_cevap4 = new System.Windows.Forms.RadioButton();
            this.rdb_cevap3 = new System.Windows.Forms.RadioButton();
            this.rdb_cevap2 = new System.Windows.Forms.RadioButton();
            this.rdb_cevap1 = new System.Windows.Forms.RadioButton();
            this.btnSonraki = new Guna.UI2.WinForms.Guna2Button();
            this.btn_bitir = new Guna.UI2.WinForms.Guna2Button();
            this.grp_soru.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sınav Ol";
            // 
            // grp_soru
            // 
            this.grp_soru.Controls.Add(this.rdb_cevap4);
            this.grp_soru.Controls.Add(this.rdb_cevap3);
            this.grp_soru.Controls.Add(this.rdb_cevap2);
            this.grp_soru.Controls.Add(this.rdb_cevap1);
            this.grp_soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grp_soru.Location = new System.Drawing.Point(138, 74);
            this.grp_soru.Name = "grp_soru";
            this.grp_soru.Size = new System.Drawing.Size(853, 485);
            this.grp_soru.TabIndex = 23;
            this.grp_soru.TabStop = false;
            this.grp_soru.Text = "soru";
            // 
            // rdb_cevap4
            // 
            this.rdb_cevap4.AutoSize = true;
            this.rdb_cevap4.ForeColor = System.Drawing.Color.Black;
            this.rdb_cevap4.Location = new System.Drawing.Point(82, 391);
            this.rdb_cevap4.Name = "rdb_cevap4";
            this.rdb_cevap4.Size = new System.Drawing.Size(131, 24);
            this.rdb_cevap4.TabIndex = 3;
            this.rdb_cevap4.TabStop = true;
            this.rdb_cevap4.Text = "radioButton4";
            this.rdb_cevap4.UseVisualStyleBackColor = true;
            // 
            // rdb_cevap3
            // 
            this.rdb_cevap3.AutoSize = true;
            this.rdb_cevap3.ForeColor = System.Drawing.Color.Black;
            this.rdb_cevap3.Location = new System.Drawing.Point(82, 286);
            this.rdb_cevap3.Name = "rdb_cevap3";
            this.rdb_cevap3.Size = new System.Drawing.Size(131, 24);
            this.rdb_cevap3.TabIndex = 2;
            this.rdb_cevap3.TabStop = true;
            this.rdb_cevap3.Text = "radioButton3";
            this.rdb_cevap3.UseVisualStyleBackColor = true;
            // 
            // rdb_cevap2
            // 
            this.rdb_cevap2.AutoSize = true;
            this.rdb_cevap2.ForeColor = System.Drawing.Color.Black;
            this.rdb_cevap2.Location = new System.Drawing.Point(82, 171);
            this.rdb_cevap2.Name = "rdb_cevap2";
            this.rdb_cevap2.Size = new System.Drawing.Size(131, 24);
            this.rdb_cevap2.TabIndex = 1;
            this.rdb_cevap2.TabStop = true;
            this.rdb_cevap2.Text = "radioButton2";
            this.rdb_cevap2.UseVisualStyleBackColor = true;
            // 
            // rdb_cevap1
            // 
            this.rdb_cevap1.AutoSize = true;
            this.rdb_cevap1.ForeColor = System.Drawing.Color.Black;
            this.rdb_cevap1.Location = new System.Drawing.Point(82, 65);
            this.rdb_cevap1.Name = "rdb_cevap1";
            this.rdb_cevap1.Size = new System.Drawing.Size(131, 24);
            this.rdb_cevap1.TabIndex = 0;
            this.rdb_cevap1.TabStop = true;
            this.rdb_cevap1.Text = "radioButton1";
            this.rdb_cevap1.UseVisualStyleBackColor = true;
            // 
            // btnSonraki
            // 
            this.btnSonraki.BorderRadius = 21;
            this.btnSonraki.BorderThickness = 1;
            this.btnSonraki.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSonraki.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSonraki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSonraki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSonraki.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSonraki.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSonraki.ForeColor = System.Drawing.Color.White;
            this.btnSonraki.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSonraki.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSonraki.Location = new System.Drawing.Point(561, 594);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(173, 44);
            this.btnSonraki.TabIndex = 28;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btn_bitir
            // 
            this.btn_bitir.BorderRadius = 21;
            this.btn_bitir.BorderThickness = 1;
            this.btn_bitir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_bitir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_bitir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_bitir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_bitir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_bitir.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bitir.ForeColor = System.Drawing.Color.White;
            this.btn_bitir.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_bitir.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_bitir.Location = new System.Drawing.Point(818, 594);
            this.btn_bitir.Name = "btn_bitir";
            this.btn_bitir.Size = new System.Drawing.Size(173, 44);
            this.btn_bitir.TabIndex = 29;
            this.btn_bitir.Text = "Bitir";
            // 
            // Ogrenci_SinavOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_bitir);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.grp_soru);
            this.Controls.Add(this.label1);
            this.Name = "Ogrenci_SinavOl";
            this.Size = new System.Drawing.Size(1205, 848);
            this.Load += new System.EventHandler(this.Ogrenci_SinavOl_Load);
            this.grp_soru.ResumeLayout(false);
            this.grp_soru.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private GroupBox grp_soru;
        private RadioButton rdb_cevap4;
        private RadioButton rdb_cevap3;
        private RadioButton rdb_cevap2;
        private RadioButton rdb_cevap1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSonraki;
        private Guna.UI2.WinForms.Guna2Button btn_bitir;
    }
}
