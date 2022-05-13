﻿using System;
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
    
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"data source = RAMAZAN;database = sinavsistemi;integrated security= True");
      
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.YeniKullaniciEkle(txt_isim.Text, txt_soyisim.Text, txt_adres.Text, txt_ogrno.Text, txt_telno.Text, txt_sifre.Text);
            MessageBox.Show("kayit basarili");
            this.Close();
            
        }
    }
}
