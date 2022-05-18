using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SınavSistemi
{
    public class ogrenci
    {
        SqlConnection baglanti = new SqlConnection(@"data source = RAMAZAN;database = sinavsistemi;integrated security= True");
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Ogrno { get; set; }
        public string Telno { get; set; }
        public string Sifre { get; set; }




        SqlDataReader oku;
        public SqlDataReader OgrenciGirisi(string ogrno,string sifre)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici where ogrNo =@ogrno", baglanti);
            komut.Parameters.Add("@ogrno", SqlDbType.NVarChar).Value = ogrno;
            komut.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifre;
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                if (sifre==oku["sifre"].ToString())
                {
                    
                    frmOgrenci frmOgrenci = new frmOgrenci();
                    frmOgrenci.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Sifrenizi Kontrol ediniz");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Komtrol edinşz");
            }
            baglanti.Close();
            return oku;



        }


        public void YeniKullaniciEkle(string ad ,string soyad ,string adres ,string ogrno, string telno, string sifre)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.Telno=telno;
            this.Sifre=sifre;
            this.Ogrno=ogrno;
            this.Adres=adres;
            SqlCommand komut = new SqlCommand("insert into kullanici(adi,soyadi,adres,ogrNo,telNo,sifre) values (@ad,@soyad,@adres,@ogrno,@telno,@sifre)", baglanti);
            komut.Parameters.AddWithValue("@ad", this.Ad);
            komut.Parameters.AddWithValue("@soyad", this.Soyad);
            komut.Parameters.AddWithValue("@adres", this.Adres);
            komut.Parameters.AddWithValue("@ogrno", this.Ogrno);
            komut.Parameters.AddWithValue("@telno", this.Telno);
            komut.Parameters.AddWithValue("@sifre", this.Sifre);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            

        }

        public void SifremiUnuttumİslemi(string ogrno, string sifre)
        {

            this.Ogrno = ogrno;
            this.Sifre = sifre;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici where ogrNo=@ogrno", baglanti);
            komut.Parameters.Add("@ogrno", SqlDbType.NVarChar).Value = ogrno;
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read() == true) 
            { 

                if (ogrno == oku["ogrNo"].ToString())
                {
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update kullanici set sifre = @sifre where ogrNo = @ogrno", baglanti);
                    komut2.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifre;
                    komut2.Parameters.Add("@ogrno", SqlDbType.NVarChar).Value = ogrno;
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İşlem Başarılı");
                    

                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz Öğrenci Numarası Bulunmamakta");
            }
            baglanti.Close();

        }
    }

    
   
}
