namespace SınavSistemi.SinavSorumlu
{
    partial class Sorumlu_SoruGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorumlu_SoruGuncelle));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboUnite = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboSoruNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.txtCevapA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCevapB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCevapC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCevapD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDogruCevap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btnResetle = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSyn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru Güncelle";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ünite";
            // 
            // comboUnite
            // 
            this.comboUnite.BackColor = System.Drawing.Color.Transparent;
            this.comboUnite.BorderColor = System.Drawing.Color.Black;
            this.comboUnite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboUnite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnite.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboUnite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboUnite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboUnite.ForeColor = System.Drawing.Color.Black;
            this.comboUnite.ItemHeight = 30;
            this.comboUnite.Location = new System.Drawing.Point(76, 123);
            this.comboUnite.Name = "comboUnite";
            this.comboUnite.Size = new System.Drawing.Size(340, 36);
            this.comboUnite.TabIndex = 2;
            this.comboUnite.SelectedIndexChanged += new System.EventHandler(this.comboUnite_SelectedIndexChanged);
            // 
            // comboSoruNo
            // 
            this.comboSoruNo.BackColor = System.Drawing.Color.Transparent;
            this.comboSoruNo.BorderColor = System.Drawing.Color.Black;
            this.comboSoruNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSoruNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSoruNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSoruNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSoruNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboSoruNo.ForeColor = System.Drawing.Color.Black;
            this.comboSoruNo.ItemHeight = 30;
            this.comboSoruNo.Location = new System.Drawing.Point(612, 123);
            this.comboSoruNo.Name = "comboSoruNo";
            this.comboSoruNo.Size = new System.Drawing.Size(340, 36);
            this.comboSoruNo.TabIndex = 4;
            this.comboSoruNo.SelectedIndexChanged += new System.EventHandler(this.comboSoruNo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(612, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soru Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(480, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soru:";
            // 
            // txtSoru
            // 
            this.txtSoru.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoru.ForeColor = System.Drawing.Color.Black;
            this.txtSoru.Location = new System.Drawing.Point(76, 220);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(876, 29);
            this.txtSoru.TabIndex = 6;
            // 
            // txtCevapA
            // 
            this.txtCevapA.BackColor = System.Drawing.SystemColors.Window;
            this.txtCevapA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCevapA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCevapA.ForeColor = System.Drawing.Color.Black;
            this.txtCevapA.Location = new System.Drawing.Point(76, 323);
            this.txtCevapA.Name = "txtCevapA";
            this.txtCevapA.Size = new System.Drawing.Size(228, 29);
            this.txtCevapA.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(76, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "A";
            // 
            // txtCevapB
            // 
            this.txtCevapB.BackColor = System.Drawing.SystemColors.Window;
            this.txtCevapB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCevapB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCevapB.ForeColor = System.Drawing.Color.Black;
            this.txtCevapB.Location = new System.Drawing.Point(724, 323);
            this.txtCevapB.Name = "txtCevapB";
            this.txtCevapB.Size = new System.Drawing.Size(228, 29);
            this.txtCevapB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(724, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "B";
            // 
            // txtCevapC
            // 
            this.txtCevapC.BackColor = System.Drawing.SystemColors.Window;
            this.txtCevapC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCevapC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCevapC.ForeColor = System.Drawing.Color.Black;
            this.txtCevapC.Location = new System.Drawing.Point(76, 419);
            this.txtCevapC.Name = "txtCevapC";
            this.txtCevapC.Size = new System.Drawing.Size(228, 29);
            this.txtCevapC.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(76, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "C";
            // 
            // txtCevapD
            // 
            this.txtCevapD.BackColor = System.Drawing.SystemColors.Window;
            this.txtCevapD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCevapD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCevapD.ForeColor = System.Drawing.Color.Black;
            this.txtCevapD.Location = new System.Drawing.Point(724, 419);
            this.txtCevapD.Name = "txtCevapD";
            this.txtCevapD.Size = new System.Drawing.Size(228, 29);
            this.txtCevapD.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(724, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "D";
            // 
            // txtDogruCevap
            // 
            this.txtDogruCevap.BackColor = System.Drawing.SystemColors.Window;
            this.txtDogruCevap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDogruCevap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDogruCevap.ForeColor = System.Drawing.Color.Black;
            this.txtDogruCevap.Location = new System.Drawing.Point(76, 504);
            this.txtDogruCevap.Name = "txtDogruCevap";
            this.txtDogruCevap.Size = new System.Drawing.Size(876, 29);
            this.txtDogruCevap.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(480, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cevap:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BorderRadius = 18;
            this.btnGuncelle.BorderThickness = 1;
            this.btnGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnGuncelle.HoverState.FillColor = System.Drawing.Color.White;
            this.btnGuncelle.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGuncelle.Location = new System.Drawing.Point(236, 596);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(180, 45);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Uptdate";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnResetle
            // 
            this.btnResetle.BorderRadius = 18;
            this.btnResetle.BorderThickness = 1;
            this.btnResetle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetle.ForeColor = System.Drawing.Color.White;
            this.btnResetle.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnResetle.HoverState.FillColor = System.Drawing.Color.White;
            this.btnResetle.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnResetle.Image = ((System.Drawing.Image)(resources.GetObject("btnResetle.Image")));
            this.btnResetle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnResetle.Location = new System.Drawing.Point(637, 596);
            this.btnResetle.Name = "btnResetle";
            this.btnResetle.Size = new System.Drawing.Size(180, 45);
            this.btnResetle.TabIndex = 18;
            this.btnResetle.Text = "Resetle";
            this.btnResetle.Click += new System.EventHandler(this.btnResetle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnSyn
            // 
            this.btnSyn.BackColor = System.Drawing.SystemColors.Window;
            this.btnSyn.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSyn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSyn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSyn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSyn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSyn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSyn.FillColor = System.Drawing.Color.Transparent;
            this.btnSyn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSyn.ForeColor = System.Drawing.Color.White;
            this.btnSyn.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSyn.Image = ((System.Drawing.Image)(resources.GetObject("btnSyn.Image")));
            this.btnSyn.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSyn.Location = new System.Drawing.Point(242, 24);
            this.btnSyn.Name = "btnSyn";
            this.btnSyn.Size = new System.Drawing.Size(34, 35);
            this.btnSyn.TabIndex = 20;
            this.btnSyn.Click += new System.EventHandler(this.btnSyn_Click);
            // 
            // Sorumlu_SoruGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSyn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResetle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtDogruCevap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCevapD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCevapC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCevapB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCevapA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSoruNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboUnite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sorumlu_SoruGuncelle";
            this.Size = new System.Drawing.Size(1600, 1059);
            this.Load += new System.EventHandler(this.Sorumlu_SoruGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private TextBox txtCevapA;
        private Label label5;
        private TextBox txtSoru;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox comboSoruNo;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox comboUnite;
        private Label label2;
        private TextBox txtDogruCevap;
        private Label label9;
        private TextBox txtCevapD;
        private Label label8;
        private TextBox txtCevapC;
        private Label label7;
        private TextBox txtCevapB;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button btnGuncelle;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnResetle;
        private Guna.UI2.WinForms.Guna2Button btnSyn;
    }
}
