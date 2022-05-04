using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavSistemi.SinavSorumlu
{
    public partial class Sorumlu_SoruGuncelle : UserControl
    {

        fonksiyon fn =new fonksiyon();
        string sorgu;

        public Sorumlu_SoruGuncelle()
        {
            InitializeComponent();
        }

        private void Sorumlu_SoruGuncelle_Load(object sender, EventArgs e)
        {
            comboUnite.Items.Clear();
            sorgu = "select distinct soruUnite from sorular";
            DataSet ds = fn.getData(sorgu);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboUnite.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboUnite_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSoruNo.Items.Clear();
            sorgu = "select soruNo from sorular where soruUnite = '" + comboUnite.Text + "'";
            DataSet ds = fn.getData(sorgu);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSoruNo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboSoruNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorgu = "select soru,secenekA,secenekB,secenekC,secenekD,cevap from sorular where soruUnite = '" + comboUnite.Text + "'and soruNo = '"+comboSoruNo.Text+"'";
            DataSet ds = fn.getData(sorgu);
            txtSoru.Text = ds.Tables[0].Rows[0][0].ToString();
            txtCevapA.Text = ds.Tables[0].Rows[0][1].ToString();
            txtCevapB.Text = ds.Tables[0].Rows[0][2].ToString();
            txtCevapC.Text = ds.Tables[0].Rows[0][3].ToString();
            txtCevapD.Text = ds.Tables[0].Rows[0][4].ToString();
            txtDogruCevap.Text = ds.Tables[0].Rows[0][5].ToString();

        }

        private void btnResetle_Click(object sender, EventArgs e)
        {
            HepsiniTemizle();
        }
        
        public void HepsiniTemizle()
        {
            txtSoru.Clear();
            txtCevapA.Clear();
            txtCevapB.Clear();
            txtCevapC.Clear();
            txtCevapD.Clear();
            txtDogruCevap.Clear();
            comboUnite.SelectedIndex = -1;
            comboSoruNo.SelectedIndex = -1;
            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (comboSoruNo.SelectedIndex != -1)
            {
                string uniteNo = comboUnite.Text;
                string soruNo = comboSoruNo.Text;
                string soru = txtSoru.Text;
                string secenekA = txtCevapA.Text;
                string secenekB = txtCevapB.Text;
                string secenekC = txtCevapC.Text;
                string secenekD = txtCevapD.Text;
                string dogruCevap = txtDogruCevap.Text;

                sorgu = "update sorular set soru = '" + soru + "',secenekA = '" + secenekA + "',secenekB = '" + secenekB + "',secenekC = '" + secenekC + "',secenekD = '" + secenekD + "',cevap = '" + dogruCevap + "'where soruUnite = '"+uniteNo+"' and soruNo = '"+soruNo+"'";
                fn.setData(sorgu, "Soru No :" + soruNo + "\n Unite No :" + uniteNo + " \n guncellendi");
                
            }
            else
            {
                MessageBox.Show("Ilk soru numarasi secin","Mesaj!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSyn_Click(object sender, EventArgs e)
        {
            Sorumlu_SoruGuncelle_Load(this, null);
        }
    }
}
