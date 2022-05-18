namespace SınavSistemi
{
    partial class frmOgrenci
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenci));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ogrenci_SinavOl1 = new SınavSistemi.Ogrenci.Ogrenci_SinavOl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncikis = new Guna.UI2.WinForms.Guna2Button();
            this.btnSinavOl = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ogrhesapcikis = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.ogrenci_SinavOl1);
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 696);
            this.panel2.TabIndex = 2;
            // 
            // ogrenci_SinavOl1
            // 
            this.ogrenci_SinavOl1.Location = new System.Drawing.Point(-3, 0);
            this.ogrenci_SinavOl1.Name = "ogrenci_SinavOl1";
            this.ogrenci_SinavOl1.Size = new System.Drawing.Size(1205, 848);
            this.ogrenci_SinavOl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.btncikis);
            this.panel1.Controls.Add(this.btnSinavOl);
            this.panel1.Controls.Add(this.btn_ogrhesapcikis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 1;
            // 
            // btncikis
            // 
            this.btncikis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncikis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncikis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncikis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncikis.FillColor = System.Drawing.Color.Turquoise;
            this.btncikis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncikis.ForeColor = System.Drawing.Color.White;
            this.btncikis.Image = ((System.Drawing.Image)(resources.GetObject("btncikis.Image")));
            this.btncikis.ImageSize = new System.Drawing.Size(35, 35);
            this.btncikis.Location = new System.Drawing.Point(6, 631);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(72, 45);
            this.btncikis.TabIndex = 8;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnSinavOl
            // 
            this.btnSinavOl.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSinavOl.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnSinavOl.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSinavOl.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSinavOl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSinavOl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSinavOl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSinavOl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSinavOl.FillColor = System.Drawing.Color.Turquoise;
            this.btnSinavOl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSinavOl.ForeColor = System.Drawing.Color.Black;
            this.btnSinavOl.Image = ((System.Drawing.Image)(resources.GetObject("btnSinavOl.Image")));
            this.btnSinavOl.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSinavOl.Location = new System.Drawing.Point(3, 484);
            this.btnSinavOl.Name = "btnSinavOl";
            this.btnSinavOl.Size = new System.Drawing.Size(263, 45);
            this.btnSinavOl.TabIndex = 7;
            this.btnSinavOl.Text = "Sınav Ol";
            this.btnSinavOl.Click += new System.EventHandler(this.btnSinavOl_Click);
            // 
            // btn_ogrhesapcikis
            // 
            this.btn_ogrhesapcikis.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_ogrhesapcikis.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_ogrhesapcikis.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_ogrhesapcikis.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_ogrhesapcikis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ogrhesapcikis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ogrhesapcikis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ogrhesapcikis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ogrhesapcikis.FillColor = System.Drawing.Color.Turquoise;
            this.btn_ogrhesapcikis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ogrhesapcikis.ForeColor = System.Drawing.Color.Black;
            this.btn_ogrhesapcikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_ogrhesapcikis.Image")));
            this.btn_ogrhesapcikis.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_ogrhesapcikis.Location = new System.Drawing.Point(3, 554);
            this.btn_ogrhesapcikis.Name = "btn_ogrhesapcikis";
            this.btn_ogrhesapcikis.Size = new System.Drawing.Size(263, 45);
            this.btn_ogrhesapcikis.TabIndex = 6;
            this.btn_ogrhesapcikis.Text = "Log Out";
            this.btn_ogrhesapcikis.Click += new System.EventHandler(this.btn_ogrhesapcikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ogrenci";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1425, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgrenci";
            this.Load += new System.EventHandler(this.frmOgrenci_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btncikis;
        private Guna.UI2.WinForms.Guna2Button btnSinavOl;
        private Guna.UI2.WinForms.Guna2Button btn_ogrhesapcikis;
        private Label label1;
        private PictureBox pictureBox2;
        private Ogrenci.Ogrenci_SinavOl ogrenci_SinavOl1;
    }
}