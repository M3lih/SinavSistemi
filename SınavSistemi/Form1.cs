namespace SınavSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            WrongLabel.Visible = false;
        }

        private void txtKullaniciSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtKullaniciSecim.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else if(txtKullaniciSecim.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;   
            }
        }

        private void checkBoxGosterGizle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGosterGizle.Checked)
            {
                txtSifre.PasswordChar = '\0';
                checkBoxGosterGizle.Text = "Şifreyi Gizle";

            }
            else
            {
                txtSifre.PasswordChar = '*';
                checkBoxGosterGizle.Text = "Şifreyi Göster";
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text =="Sorumlu" && txtSifre.Text =="Sorumlu")
            {
                WrongLabel.Visible = false;
                Sorumlu sorumlu = new Sorumlu();
                sorumlu.Show();
                this.Hide();
            }
            else
            {
                WrongLabel.Visible = true;
            }
        }
    }
}