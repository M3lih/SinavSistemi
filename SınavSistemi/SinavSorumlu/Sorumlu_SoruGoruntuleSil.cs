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
    public partial class Sorumlu_SoruGoruntuleSil : UserControl
    {

        fonksiyon fn = new fonksiyon();
        String sorgu;

        public Sorumlu_SoruGoruntuleSil()
        {
            InitializeComponent();
        }

        private void Sorumlu_SoruGoruntuleSil_Load(object sender, EventArgs e)
        {
            comboUnite.Items.Clear();
            comboUnite.Items.Add("Tum Sorular");
            sorgu = "select distinct soruUnite from sorular";
            DataSet ds = fn.getData(sorgu);

            for(int i = 0; i<ds.Tables[0].Rows.Count; i++)
            {
                comboUnite.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboUnite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboUnite.SelectedIndex != 0)
            {
                sorgu = "select soruID,soruNo,soru,secenekA,secenekB,secenekC,secenekD,cevap from sorular where soruUnite = '"+comboUnite.Text+"'";
                DataSet ds = fn.getData(sorgu);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                sorgu = "select soruID,soruNo,soru,secenekA,secenekB,secenekC,secenekD,cevap from sorular";
                DataSet ds = fn.getData(sorgu);   
                dataGridView1.DataSource=ds.Tables[0];  
            }
        }


        int id, soruNo;

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                soruNo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch { }
        }

        private void btnSyn_Click(object sender, EventArgs e)
        {
            Sorumlu_SoruGoruntuleSil_Load(this, null);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Emin misin?","Silme Onaylama!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                sorgu = "delete from sorular where soruID = " + id + " and soruNo = '" + soruNo + "'";
                fn.setData(sorgu, "Soru Silindi.");
                Sorumlu_SoruGoruntuleSil_Load(this, null);
            }
        }
    }
}
