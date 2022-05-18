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
            this.sayac = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDakika = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.grp_soru.SuspendLayout();
            this.sayac.SuspendLayout();
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
            this.grp_soru.Location = new System.Drawing.Point(57, 87);
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
            this.btnSonraki.Location = new System.Drawing.Point(86, 599);
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
            this.btn_bitir.Location = new System.Drawing.Point(360, 599);
            this.btn_bitir.Name = "btn_bitir";
            this.btn_bitir.Size = new System.Drawing.Size(173, 44);
            this.btn_bitir.TabIndex = 29;
            this.btn_bitir.Text = "Bitir";
            this.btn_bitir.Click += new System.EventHandler(this.btn_bitir_Click);
            // 
            // sayac
            // 
            this.sayac.Controls.Add(this.label2);
            this.sayac.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.sayac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sayac.ForeColor = System.Drawing.Color.White;
            this.sayac.Location = new System.Drawing.Point(942, 77);
            this.sayac.Maximum = 600;
            this.sayac.Minimum = 0;
            this.sayac.Name = "sayac";
            this.sayac.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.sayac.Size = new System.Drawing.Size(108, 108);
            this.sayac.TabIndex = 30;
            this.sayac.Text = "guna2CircleProgressBar1";
            this.sayac.Value = 600;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Süre";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDakika.ForeColor = System.Drawing.Color.Black;
            this.lblDakika.Location = new System.Drawing.Point(928, 237);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(41, 40);
            this.lblDakika.TabIndex = 31;
            this.lblDakika.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(990, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 40);
            this.label4.TabIndex = 31;
            this.label4.Text = ":";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaniye.ForeColor = System.Drawing.Color.Black;
            this.lblSaniye.Location = new System.Drawing.Point(1052, 237);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(41, 40);
            this.lblSaniye.TabIndex = 31;
            this.lblSaniye.Text = "--";
            // 
            // Ogrenci_SinavOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.sayac);
            this.Controls.Add(this.btn_bitir);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.grp_soru);
            this.Controls.Add(this.label1);
            this.Name = "Ogrenci_SinavOl";
            this.Size = new System.Drawing.Size(1205, 848);
            this.Load += new System.EventHandler(this.Ogrenci_SinavOl_Load);
            this.grp_soru.ResumeLayout(false);
            this.grp_soru.PerformLayout();
            this.sayac.ResumeLayout(false);
            this.sayac.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2CircleProgressBar sayac;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label lblSaniye;
        private Label label4;
        private Label lblDakika;
    }
}
