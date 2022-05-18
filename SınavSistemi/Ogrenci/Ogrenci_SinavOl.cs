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

namespace SınavSistemi.Ogrenci
{
    public partial class Ogrenci_SinavOl : UserControl
    {
        public Ogrenci_SinavOl()
        {
            InitializeComponent();
            SoruGetir();
            
        }
        SqlConnection baglanti = new SqlConnection(@"data source = RAMAZAN;database = sinavsistemi;integrated security= True");

        int saniye = 60;
        int dakika = 0;
        private void Ogrenci_SinavOl_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dakika = Convert.ToInt32(10);
        }

        string a1;
      

        int sorusayisi = 0;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (sorusayisi <9)
            {
                SoruGetir();
                CevapKontrol();
                sorusayisi++;
               
            }
            else
            {
                MessageBox.Show("Son Sorudasınız !");
            }
 
            
        }

        private int RandomSayi()
        {
            Random rd = new Random();
            int x = rd.Next(1,80);
            return x;
        }
        public void SoruGetir()
        {
            try
            {
                int sorunumarasi = RandomSayi();
                baglanti.Open();    
                SqlCommand komut = new SqlCommand("select *from sorular where soruID = '"+sorunumarasi+"'",baglanti);
                DataTable tablo = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(komut);
                sda.Fill(tablo);
                foreach (DataRow dr in tablo.Rows)
                {
                    grp_soru.Text = dr["soru"].ToString();
                    rdb_cevap1.Text = dr["secenekA"].ToString();
                    rdb_cevap2.Text = dr["secenekB"].ToString();
                    rdb_cevap3.Text = dr["secenekC"].ToString();
                    rdb_cevap4.Text = dr["secenekD"].ToString();
                    a1 = dr["cevap"].ToString();

                }
                baglanti.Close();   
            }
            catch (Exception)
            {

                throw;
            }

            
            
        }
        string[] SoruCevap = new string[10];
        int dogrusayisi = 0;
        private void CevapKontrol()
        {
            if (rdb_cevap1.Checked)
            {
                SoruCevap[0] = " ";
                SoruCevap[0] = rdb_cevap1.Text;
            }
            else if (rdb_cevap2.Checked)
            {
                SoruCevap[0] = " ";
                SoruCevap[0] = rdb_cevap2.Text;

            }
            else if (rdb_cevap3.Checked)
            {
                SoruCevap[0] = " ";
                SoruCevap[0] = rdb_cevap3.Text;
            }
            else if (rdb_cevap4.Checked)
            {
                SoruCevap[0] = " ";
                SoruCevap[0] = rdb_cevap4.Text;
            }
            if (SoruCevap[0] == a1)
            {
                dogrusayisi = dogrusayisi + 1;
            }
            else
            {
                dogrusayisi = dogrusayisi;
            }
        }

        private void btn_bitir_Click(object sender, EventArgs e)
        {
            CevapKontrol();
            MessageBox.Show("" + dogrusayisi);
            frmOgrenci frmOgrenci = new frmOgrenci();
            frmOgrenci.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye= saniye - 1;
            lblSaniye.Text=saniye.ToString();
            lblDakika.Text=(dakika-1).ToString();
            if (saniye == 0)
            {
                dakika = dakika - 1;
                lblDakika.Text=dakika.ToString();
                saniye = 60;
            }
        }
    }
}
