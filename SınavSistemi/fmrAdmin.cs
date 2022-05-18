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
    public partial class fmrAdmin : Form
    {
        public fmrAdmin()
        {
            InitializeComponent();
        }

        private void fmrAdmin_Load(object sender, EventArgs e)
        {
            admin_SoruOnaylaSil1.Visible = false;
    
        }

        private void btnSoruOnaylaSil_Click(object sender, EventArgs e)
        {
            admin_SoruOnaylaSil1.Visible=true;
            admin_SoruOnaylaSil1.BringToFront();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_admhesapcikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            
        }
    }
}
