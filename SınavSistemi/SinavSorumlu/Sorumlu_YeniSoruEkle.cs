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

namespace SınavSistemi.SinavSorumlu
{
    public partial class Sorumlu_YeniSoruEkle : UserControl
    {
        fonksiyon fn = new fonksiyon();
        String sorgu;
        DataSet ds;
        Int64 soruNo = 1;
        public Sorumlu_YeniSoruEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sorumlu_YeniSoruEkle_Load(object sender, EventArgs e)
        {
            sorgu = "select max(soruUnite) from sorular";
            ds = fn.getData(sorgu);
            if(ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString()); 
                txtUnite.Text = (id+1).ToString();
            }
            else
            {
                txtUnite.Text = "1";
            }
            lblSoruNo.Text = soruNo.ToString();
            lblHatali.Visible = false; 
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            string soruUnite = txtUnite.Text;
            string soruNo = this.soruNo.ToString();
            string soru = txtSoru.Text;
            string secenekA = txtSecenekA.Text;
            string secenekB = txtSecenekB.Text;
            string secenekC = txtSecenekC.Text;
            string secenekD = txtSecenekD.Text;
            string cevap = txtCevap.Text;
            string resim = txtResim.Text;

            sorgu = "insert into sorular (soruUnite,soruNo,soru,secenekA,secenekB,secenekC,secenekD,cevap,soruResim) values('" +soruUnite+"','"+soruNo+"','"+soru+"','" +secenekA+ "','" + secenekB + "','" + secenekC + "','" + secenekD + "','"+cevap+"','"+txtResim+"' )";
            fn.setData(sorgu, "Soru eklendi.");
            temizle();
            this.soruNo++;
            lblSoruNo.Text= this.soruNo.ToString();  

        }
        public void temizle()
        {
            txtSoru.Clear();
            txtSecenekA.Clear();
            txtSecenekB.Clear();  
            txtSecenekC.Clear();
            txtSecenekD.Clear();
            txtCevap.Clear();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kaydetmediginiz veriler silinecektir!","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                temizle();
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Degisiklikler kaydedilecektir","Uyari",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                txtUnite.Text = (Int64.Parse(txtUnite.Text.ToString())+1 ).ToString();
                lblSoruNo.Text = "1";
            }
        }

        private void txtUnite_TextChanged(object sender, EventArgs e)
        {
            if(txtUnite.Text != "")
            {
                temizle();
                sorgu = "select soruNo from sorular where soruUnite = '" + txtUnite.Text + "'";
                ds = fn.getData(sorgu);
                if(ds.Tables[0].Rows.Count!=0 && ds.Tables[0].Rows[0][0].ToString()!= "")
                {
                    lblSoruNo.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    soruNo = Int64.Parse(lblSoruNo.Text.ToString());
                }

                else
                {
                    lblSoruNo.Text = "1";
                    soruNo = Int64.Parse(lblSoruNo.Text.ToString());
                    lblHatali.Visible = true;
                }
            }
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }
    }
}
