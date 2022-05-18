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
        private void Ogrenci_SinavOl_Load(object sender, EventArgs e)
        {

        }

        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;


        int sorusayisi = 0;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (sorusayisi <2)
            {
                SoruGetir();
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
            int x = rd.Next(1,4);
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
           
    }
}
