using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavSistemi
{
    public partial class Sorumlu : Form
    {
        public Sorumlu()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sorumlu_Load(object sender, EventArgs e)
        {
            sorumlu_YeniSoruEkle1.Visible = false;
            sorumlu_SoruGuncelle1.Visible = false;
            sorumlu_SoruGoruntuleSil1.Visible = false;
        }

        private void BtnSoruEkle_Click(object sender, EventArgs e)
        {
            sorumlu_YeniSoruEkle1.Visible = true;
            sorumlu_YeniSoruEkle1.BringToFront();   
        }

        private void btnSoruGuncelle_Click(object sender, EventArgs e)
        {
            sorumlu_SoruGuncelle1.Visible=true;
            sorumlu_SoruGuncelle1.BringToFront();
        }

        private void btnSoruGoruntuleSil_Click(object sender, EventArgs e)
        {
            sorumlu_SoruGoruntuleSil1.Visible=true;
            sorumlu_SoruGoruntuleSil1.BringToFront();

        }

        private void btn_hesapcikis_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            this.Close();
            form1.ShowDialog();
        }
    }
}
