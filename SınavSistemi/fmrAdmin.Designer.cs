namespace SınavSistemi
{
    partial class fmrAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncikis = new Guna.UI2.WinForms.Guna2Button();
            this.btnSoruOnaylaSil = new Guna.UI2.WinForms.Guna2Button();
            this.btn_admhesapcikis = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_SoruOnaylaSil1 = new SınavSistemi.Admin.Admin_SoruOnaylaSil();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btncikis);
            this.panel1.Controls.Add(this.btnSoruOnaylaSil);
            this.panel1.Controls.Add(this.btn_admhesapcikis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 676);
            this.panel2.TabIndex = 2;
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
            // btnSoruOnaylaSil
            // 
            this.btnSoruOnaylaSil.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSoruOnaylaSil.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnSoruOnaylaSil.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSoruOnaylaSil.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSoruOnaylaSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSoruOnaylaSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSoruOnaylaSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSoruOnaylaSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSoruOnaylaSil.FillColor = System.Drawing.Color.Turquoise;
            this.btnSoruOnaylaSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoruOnaylaSil.ForeColor = System.Drawing.Color.Black;
            this.btnSoruOnaylaSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruOnaylaSil.Image")));
            this.btnSoruOnaylaSil.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSoruOnaylaSil.Location = new System.Drawing.Point(6, 308);
            this.btnSoruOnaylaSil.Name = "btnSoruOnaylaSil";
            this.btnSoruOnaylaSil.Size = new System.Drawing.Size(263, 45);
            this.btnSoruOnaylaSil.TabIndex = 7;
            this.btnSoruOnaylaSil.Text = "Soru Sil";
            this.btnSoruOnaylaSil.Click += new System.EventHandler(this.btnSoruOnaylaSil_Click);
            // 
            // btn_admhesapcikis
            // 
            this.btn_admhesapcikis.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_admhesapcikis.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_admhesapcikis.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_admhesapcikis.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_admhesapcikis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_admhesapcikis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_admhesapcikis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_admhesapcikis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_admhesapcikis.FillColor = System.Drawing.Color.Turquoise;
            this.btn_admhesapcikis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_admhesapcikis.ForeColor = System.Drawing.Color.Black;
            this.btn_admhesapcikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_admhesapcikis.Image")));
            this.btn_admhesapcikis.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_admhesapcikis.Location = new System.Drawing.Point(6, 377);
            this.btn_admhesapcikis.Name = "btn_admhesapcikis";
            this.btn_admhesapcikis.Size = new System.Drawing.Size(263, 45);
            this.btn_admhesapcikis.TabIndex = 6;
            this.btn_admhesapcikis.Text = "Log Out";
            this.btn_admhesapcikis.Click += new System.EventHandler(this.btn_admhesapcikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // admin_SoruOnaylaSil1
            // 
            this.admin_SoruOnaylaSil1.BackColor = System.Drawing.Color.White;
            this.admin_SoruOnaylaSil1.Location = new System.Drawing.Point(274, 0);
            this.admin_SoruOnaylaSil1.Name = "admin_SoruOnaylaSil1";
            this.admin_SoruOnaylaSil1.Size = new System.Drawing.Size(1205, 848);
            this.admin_SoruOnaylaSil1.TabIndex = 3;
            // 
            // fmrAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1441, 679);
            this.Controls.Add(this.admin_SoruOnaylaSil1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btncikis;
        private Guna.UI2.WinForms.Guna2Button btnSoruOnaylaSil;
        private Guna.UI2.WinForms.Guna2Button btn_admhesapcikis;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PictureBox pictureBox1;
        private Admin.Admin_SoruOnaylaSil admin_SoruOnaylaSil1;
    }
}