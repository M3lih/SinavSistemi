using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SınavSistemi
{
    public partial class frmSifre : Form
    {
        public frmSifre()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"data source = RAMAZAN;database = sinavsistemi;integrated security= True");

        private void btn_sifredegistir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =new SqlCommand("select * from kullanici where ogrNo = '"+txt_yogrno.Text+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {

           
             if (txt_yogrno.Text==oku["ogrNo"].ToString())
              {
               baglanti.Close();
               baglanti.Open();
                    SqlCommand kmt = new SqlCommand("update kullanici set sifre = '"+txt_yeniSifre.Text+"' where ogrNo = '"+txt_yogrno.Text+"'",baglanti);
                    kmt.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İslem Basarili");
                    this.Hide();
              }
            
            }
            else
            {
                MessageBox.Show("Girdiğiniz Ogrenci Numarası Bulunmamaktadır");
            }
            baglanti.Close();
        }
    }
}
