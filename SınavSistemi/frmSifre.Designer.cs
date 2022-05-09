namespace SınavSistemi
{
    partial class frmSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifre));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sifredegistir = new System.Windows.Forms.Button();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.txt_yogrno = new System.Windows.Forms.TextBox();
            this.txt_ysoyisim = new System.Windows.Forms.TextBox();
            this.txt_yisim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_sifredegistir);
            this.groupBox1.Controls.Add(this.txt_yeniSifre);
            this.groupBox1.Controls.Add(this.txt_yogrno);
            this.groupBox1.Controls.Add(this.txt_ysoyisim);
            this.groupBox1.Controls.Add(this.txt_yisim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Yenileme";
            // 
            // btn_sifredegistir
            // 
            this.btn_sifredegistir.Location = new System.Drawing.Point(272, 279);
            this.btn_sifredegistir.Name = "btn_sifredegistir";
            this.btn_sifredegistir.Size = new System.Drawing.Size(131, 34);
            this.btn_sifredegistir.TabIndex = 11;
            this.btn_sifredegistir.Text = "Şifre Değiştir";
            this.btn_sifredegistir.UseVisualStyleBackColor = true;
            this.btn_sifredegistir.Click += new System.EventHandler(this.btn_sifredegistir_Click);
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.Location = new System.Drawing.Point(148, 214);
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.PasswordChar = '*';
            this.txt_yeniSifre.Size = new System.Drawing.Size(255, 26);
            this.txt_yeniSifre.TabIndex = 10;
            // 
            // txt_yogrno
            // 
            this.txt_yogrno.Location = new System.Drawing.Point(148, 157);
            this.txt_yogrno.Name = "txt_yogrno";
            this.txt_yogrno.Size = new System.Drawing.Size(255, 26);
            this.txt_yogrno.TabIndex = 8;
            // 
            // txt_ysoyisim
            // 
            this.txt_ysoyisim.Location = new System.Drawing.Point(148, 95);
            this.txt_ysoyisim.Name = "txt_ysoyisim";
            this.txt_ysoyisim.Size = new System.Drawing.Size(255, 26);
            this.txt_ysoyisim.TabIndex = 6;
            // 
            // txt_yisim
            // 
            this.txt_yisim.Location = new System.Drawing.Point(148, 36);
            this.txt_yisim.Name = "txt_yisim";
            this.txt_yisim.Size = new System.Drawing.Size(255, 26);
            this.txt_yisim.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Yeni Sifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Öğrenci No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyİsim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // frmSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 421);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSifre";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_sifredegistir;
        private TextBox txt_yeniSifre;
        private TextBox txt_yogrno;
        private TextBox txt_ysoyisim;
        private TextBox txt_yisim;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}