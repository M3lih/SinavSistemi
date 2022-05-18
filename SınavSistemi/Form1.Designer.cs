namespace SınavSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciSecim = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxGosterGizle = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnk_sifreunuttum = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.btnOgrenciKayit = new System.Windows.Forms.Button();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.txt_admkullanici = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_admsifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.73585F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(699, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınav Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(819, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Türü Seçiniz";
            // 
            // txtKullaniciSecim
            // 
            this.txtKullaniciSecim.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciSecim.FormattingEnabled = true;
            this.txtKullaniciSecim.Items.AddRange(new object[] {
            "Ogrenci",
            "Sınav Sorumlusu",
            "Admin"});
            this.txtKullaniciSecim.Location = new System.Drawing.Point(752, 204);
            this.txtKullaniciSecim.Name = "txtKullaniciSecim";
            this.txtKullaniciSecim.Size = new System.Drawing.Size(330, 29);
            this.txtKullaniciSecim.TabIndex = 1;
            this.txtKullaniciSecim.SelectedIndexChanged += new System.EventHandler(this.txtKullaniciSecim_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1245, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 81);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxGosterGizle);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.WrongLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(716, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 375);
            this.panel1.TabIndex = 4;
            // 
            // checkBoxGosterGizle
            // 
            this.checkBoxGosterGizle.AutoSize = true;
            this.checkBoxGosterGizle.Location = new System.Drawing.Point(138, 227);
            this.checkBoxGosterGizle.Name = "checkBoxGosterGizle";
            this.checkBoxGosterGizle.Size = new System.Drawing.Size(94, 19);
            this.checkBoxGosterGizle.TabIndex = 5;
            this.checkBoxGosterGizle.Text = "Sifreyi goster";
            this.checkBoxGosterGizle.UseVisualStyleBackColor = true;
            this.checkBoxGosterGizle.CheckedChanged += new System.EventHandler(this.checkBoxGosterGizle_CheckedChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 12.22642F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(21, 261);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(337, 37);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(21, 184);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(337, 29);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(21, 131);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(337, 29);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(125, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kullanici Adi";
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WrongLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WrongLabel.Location = new System.Drawing.Point(86, 319);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(193, 17);
            this.WrongLabel.TabIndex = 0;
            this.WrongLabel.Text = "Yanlıs Kullanıcı Adı veya Sifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(157, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(125, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sorumlu Giris";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lnk_sifreunuttum);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSifre2);
            this.panel2.Controls.Add(this.btnOgrenciKayit);
            this.panel2.Controls.Add(this.btnOgrenciGiris);
            this.panel2.Controls.Add(this.txtOgrenciNo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(719, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 354);
            this.panel2.TabIndex = 4;
            // 
            // lnk_sifreunuttum
            // 
            this.lnk_sifreunuttum.AutoSize = true;
            this.lnk_sifreunuttum.Location = new System.Drawing.Point(137, 304);
            this.lnk_sifreunuttum.Name = "lnk_sifreunuttum";
            this.lnk_sifreunuttum.Size = new System.Drawing.Size(95, 15);
            this.lnk_sifreunuttum.TabIndex = 5;
            this.lnk_sifreunuttum.TabStop = true;
            this.lnk_sifreunuttum.Text = "Şifremi Unuttum";
            this.lnk_sifreunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(157, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Şifre";
            // 
            // txtSifre2
            // 
            this.txtSifre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre2.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSifre2.ForeColor = System.Drawing.Color.Black;
            this.txtSifre2.Location = new System.Drawing.Point(31, 149);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.PasswordChar = '*';
            this.txtSifre2.Size = new System.Drawing.Size(337, 29);
            this.txtSifre2.TabIndex = 2;
            this.txtSifre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOgrenciKayit
            // 
            this.btnOgrenciKayit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOgrenciKayit.Font = new System.Drawing.Font("Segoe UI", 12.22642F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciKayit.ForeColor = System.Drawing.Color.White;
            this.btnOgrenciKayit.Location = new System.Drawing.Point(21, 259);
            this.btnOgrenciKayit.Name = "btnOgrenciKayit";
            this.btnOgrenciKayit.Size = new System.Drawing.Size(337, 37);
            this.btnOgrenciKayit.TabIndex = 4;
            this.btnOgrenciKayit.Text = "Kayıt OL";
            this.btnOgrenciKayit.UseVisualStyleBackColor = false;
            this.btnOgrenciKayit.Click += new System.EventHandler(this.btnOgrenciKayit_Click);
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOgrenciGiris.Font = new System.Drawing.Font("Segoe UI", 12.22642F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciGiris.ForeColor = System.Drawing.Color.White;
            this.btnOgrenciGiris.Location = new System.Drawing.Point(21, 206);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(337, 37);
            this.btnOgrenciGiris.TabIndex = 3;
            this.btnOgrenciGiris.Text = "Giriş";
            this.btnOgrenciGiris.UseVisualStyleBackColor = false;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOgrenciNo.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOgrenciNo.ForeColor = System.Drawing.Color.Black;
            this.txtOgrenciNo.Location = new System.Drawing.Point(31, 96);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(337, 29);
            this.txtOgrenciNo.TabIndex = 1;
            this.txtOgrenciNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOgrenciNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(86, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ogrenci Giris Numara";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(125, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ogrenci Giris";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdminGiris);
            this.panel3.Controls.Add(this.txt_admkullanici);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_admsifre);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(752, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 375);
            this.panel3.TabIndex = 5;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdminGiris.Font = new System.Drawing.Font("Segoe UI", 12.22642F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAdminGiris.ForeColor = System.Drawing.Color.White;
            this.btnAdminGiris.Location = new System.Drawing.Point(13, 259);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(358, 37);
            this.btnAdminGiris.TabIndex = 3;
            this.btnAdminGiris.Text = "Giriş";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // txt_admkullanici
            // 
            this.txt_admkullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_admkullanici.ForeColor = System.Drawing.Color.Black;
            this.txt_admkullanici.Location = new System.Drawing.Point(13, 123);
            this.txt_admkullanici.Name = "txt_admkullanici";
            this.txt_admkullanici.Size = new System.Drawing.Size(358, 23);
            this.txt_admkullanici.TabIndex = 1;
            this.txt_admkullanici.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(168, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Şifre";
            // 
            // txt_admsifre
            // 
            this.txt_admsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_admsifre.ForeColor = System.Drawing.Color.Black;
            this.txt_admsifre.Location = new System.Drawing.Point(13, 201);
            this.txt_admsifre.Name = "txt_admsifre";
            this.txt_admsifre.PasswordChar = '*';
            this.txt_admsifre.Size = new System.Drawing.Size(358, 23);
            this.txt_admsifre.TabIndex = 2;
            this.txt_admsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(134, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(135, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Admin Girişi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1368, 678);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtKullaniciSecim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox txtKullaniciSecim;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtKullaniciAdi;
        private Label label5;
        private Label WrongLabel;
        private Label label4;
        private Label label3;
        private Button btnGiris;
        private TextBox txtSifre;
        private CheckBox checkBoxGosterGizle;
        private Panel panel2;
        private Button btnOgrenciKayit;
        private Button btnOgrenciGiris;
        private TextBox txtOgrenciNo;
        private Label label8;
        private Label label11;
        private Label label6;
        private TextBox txtSifre2;
        private LinkLabel lnk_sifreunuttum;
        private Panel panel3;
        private Button btnAdminGiris;
        private TextBox txt_admkullanici;
        private Label label12;
        private TextBox txt_admsifre;
        private Label label9;
        private Label label7;
    }
}