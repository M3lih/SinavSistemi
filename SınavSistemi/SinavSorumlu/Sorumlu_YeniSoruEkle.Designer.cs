namespace SınavSistemi.SinavSorumlu
{
    partial class Sorumlu_YeniSoruEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecenekA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSecenekC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSecenekD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSecenekB = new System.Windows.Forms.TextBox();
            this.lblHatali = new System.Windows.Forms.Label();
            this.btnSonraki = new Guna.UI2.WinForms.Guna2Button();
            this.btnSifirla = new Guna.UI2.WinForms.Guna2Button();
            this.btnBitir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ünite";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUnite
            // 
            this.txtUnite.ForeColor = System.Drawing.Color.Black;
            this.txtUnite.Location = new System.Drawing.Point(33, 161);
            this.txtUnite.Name = "txtUnite";
            this.txtUnite.Size = new System.Drawing.Size(415, 25);
            this.txtUnite.TabIndex = 2;
            this.txtUnite.TextChanged += new System.EventHandler(this.txtUnite_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(651, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soru No:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.BackColor = System.Drawing.Color.White;
            this.lblSoruNo.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSoruNo.ForeColor = System.Drawing.Color.Red;
            this.lblSoruNo.Location = new System.Drawing.Point(684, 184);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(34, 24);
            this.lblSoruNo.TabIndex = 1;
            this.lblSoruNo.Text = "11";
            this.lblSoruNo.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(71, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Soru";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoru
            // 
            this.txtSoru.ForeColor = System.Drawing.Color.Black;
            this.txtSoru.Location = new System.Drawing.Point(68, 258);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(415, 25);
            this.txtSoru.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(68, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "A:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSecenekA
            // 
            this.txtSecenekA.ForeColor = System.Drawing.Color.Black;
            this.txtSecenekA.Location = new System.Drawing.Point(68, 397);
            this.txtSecenekA.Name = "txtSecenekA";
            this.txtSecenekA.Size = new System.Drawing.Size(415, 25);
            this.txtSecenekA.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(606, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cevap";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCevap
            // 
            this.txtCevap.ForeColor = System.Drawing.Color.Black;
            this.txtCevap.Location = new System.Drawing.Point(606, 564);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(415, 25);
            this.txtCevap.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(68, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "C:";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSecenekC
            // 
            this.txtSecenekC.ForeColor = System.Drawing.Color.Black;
            this.txtSecenekC.Location = new System.Drawing.Point(71, 595);
            this.txtSecenekC.Name = "txtSecenekC";
            this.txtSecenekC.Size = new System.Drawing.Size(415, 25);
            this.txtSecenekC.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(68, 656);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "D:";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSecenekD
            // 
            this.txtSecenekD.ForeColor = System.Drawing.Color.Black;
            this.txtSecenekD.Location = new System.Drawing.Point(68, 717);
            this.txtSecenekD.Name = "txtSecenekD";
            this.txtSecenekD.Size = new System.Drawing.Size(415, 25);
            this.txtSecenekD.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(68, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "B:";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSecenekB
            // 
            this.txtSecenekB.ForeColor = System.Drawing.Color.Black;
            this.txtSecenekB.Location = new System.Drawing.Point(71, 508);
            this.txtSecenekB.Name = "txtSecenekB";
            this.txtSecenekB.Size = new System.Drawing.Size(415, 25);
            this.txtSecenekB.TabIndex = 2;
            // 
            // lblHatali
            // 
            this.lblHatali.AutoSize = true;
            this.lblHatali.BackColor = System.Drawing.Color.White;
            this.lblHatali.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHatali.ForeColor = System.Drawing.Color.Red;
            this.lblHatali.Location = new System.Drawing.Point(123, 199);
            this.lblHatali.Name = "lblHatali";
            this.lblHatali.Size = new System.Drawing.Size(91, 19);
            this.lblHatali.TabIndex = 1;
            this.lblHatali.Text = "Hatalı giriş";
            this.lblHatali.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.BorderRadius = 18;
            this.btnSonraki.BorderThickness = 1;
            this.btnSonraki.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSonraki.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSonraki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSonraki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSonraki.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSonraki.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSonraki.ForeColor = System.Drawing.Color.White;
            this.btnSonraki.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnSonraki.Location = new System.Drawing.Point(606, 615);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(199, 50);
            this.btnSonraki.TabIndex = 3;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BorderRadius = 18;
            this.btnSifirla.BorderThickness = 1;
            this.btnSifirla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSifirla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSifirla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSifirla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSifirla.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSifirla.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSifirla.ForeColor = System.Drawing.Color.White;
            this.btnSifirla.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnSifirla.Location = new System.Drawing.Point(810, 615);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(199, 50);
            this.btnSifirla.TabIndex = 3;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.Color.White;
            this.btnBitir.BorderRadius = 18;
            this.btnBitir.BorderThickness = 1;
            this.btnBitir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBitir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBitir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBitir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBitir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBitir.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBitir.ForeColor = System.Drawing.Color.Black;
            this.btnBitir.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnBitir.Location = new System.Drawing.Point(606, 671);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(403, 50);
            this.btnBitir.TabIndex = 3;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Sorumlu_YeniSoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.txtSecenekD);
            this.Controls.Add(this.txtSecenekC);
            this.Controls.Add(this.txtSecenekB);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSecenekA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUnite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHatali);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Sorumlu_YeniSoruEkle";
            this.Size = new System.Drawing.Size(1091, 870);
            this.Load += new System.EventHandler(this.Sorumlu_YeniSoruEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUnite;
        private Label label3;
        private Label lblSoruNo;
        private Label label5;
        private TextBox txtSoru;
        private Label label6;
        private TextBox txtSecenekA;
        private Label label7;
        private TextBox txtCevap;
        private Label label8;
        private TextBox txtSecenekC;
        private Label label9;
        private TextBox txtSecenekD;
        private Label label10;
        private TextBox txtSecenekB;
        private Label lblHatali;
        private Guna.UI2.WinForms.Guna2Button btnSonraki;
        private Guna.UI2.WinForms.Guna2Button btnSifirla;
        private Guna.UI2.WinForms.Guna2Button btnBitir;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
