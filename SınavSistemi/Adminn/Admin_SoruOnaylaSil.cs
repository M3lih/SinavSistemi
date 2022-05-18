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


namespace SınavSistemi.Admin
{
    public partial class Admin_SoruOnaylaSil : UserControl
    {
        int id, soruNo;
        SqlConnection baglanti = new SqlConnection(@"data source = RAMAZAN;database = sinavsistemi;integrated security= True");
        public Admin_SoruOnaylaSil()
        {
            InitializeComponent();
        }

        private void Admin_SoruOnaylaSil_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from sorular ",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
      

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin misin?", "Silme Onaylama!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from sorular where soruID = '" + dataGridView1.SelectedRows[i].Cells["soruID"].Value.ToString() + "'", baglanti); 
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Kayıt Silinidi");
                Admin_SoruOnaylaSil_Load(this, null);
            }
        }
    }
}
