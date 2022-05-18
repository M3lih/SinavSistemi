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
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }

        private void btnSinavOl_Click(object sender, EventArgs e)
        {
            ogrenci_SinavOl1.Visible = true;
            ogrenci_SinavOl1.BringToFront();
            
            
        }

        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            ogrenci_SinavOl1.Visible=false;
        }

        private void btn_ogrhesapcikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.ShowDialog();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
