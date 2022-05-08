using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavSistemi
{
    class fonksiyon
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MK;database = sinavsistemi;integrated security= True";
            return con;
        }
        
        public DataSet getData(String sorgu)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;   
            cmd.CommandText = sorgu;    
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds =new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string sorgu,string msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();  
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = sorgu;    
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public SqlDataReader getForCombo(string sorgu)
        {
            SqlConnection con = getConnection();    
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(sorgu,con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;

        }
    }
}
