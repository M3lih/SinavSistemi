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
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.SifremiUnuttumİslemi(txt_yogrno.Text, txt_yeniSifre.Text);
            this.Hide();
        }
    }
}
