
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SınavSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        SqlConnection baglanti = new SqlConnection(@"data source = RAMAZAN;database = sinavsistemi;integrated security= True");
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            WrongLabel.Visible = false;
        }

        private void txtKullaniciSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtKullaniciSecim.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;

            }
            else if(txtKullaniciSecim.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;   
            }
        }

        private void checkBoxGosterGizle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGosterGizle.Checked)
            {
                txtSifre.PasswordChar = '\0';
                checkBoxGosterGizle.Text = "Şifreyi Gizle";

            }
            else
            {
                txtSifre.PasswordChar = '*';
                checkBoxGosterGizle.Text = "Şifreyi Göster";
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text =="Sorumlu" && txtSifre.Text =="Sorumlu")
            {
                WrongLabel.Visible = false;
                Sorumlu sorumlu = new Sorumlu();
                sorumlu.Show();
                this.Hide();
            }
            else
            {
                WrongLabel.Visible = true;
            }
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            frmKayit kayit = new frmKayit();
            kayit.ShowDialog();
           
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string ogrenciNo = txtOgrenciNo.Text;
            string sifre = txtSifre2.Text;

            SqlCommand komut = new SqlCommand("select * from kullanici where ogrNo = '" + ogrenciNo + "' and sifre = '"+sifre+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Hosgeldiniz");
            }
            else
            {
                MessageBox.Show("Yanlış Ogrenci No Veya Sifre Girisi");
               
            }

            baglanti.Close();   
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifre sifre = new frmSifre();
            sifre.ShowDialog();
        }
    }
}