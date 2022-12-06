using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace giris
{
    public partial class hastalikekle : Form
    {
        public hastalikekle()
        {
            InitializeComponent();
        }
       
        OleDbConnection eczanebaglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "//vt_eczane.accdb"); 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hastalikekle_Load(object sender, EventArgs e)
        {

        }

        private void but_kaydet_Click(object sender, EventArgs e)
        {
            eczanebaglanti.Open();
            OleDbCommand hastalikkaydet = new OleDbCommand();
            hastalikkaydet.Parameters.AddWithValue("@hastalik_adi", text_hadi.Text);
            hastalikkaydet.Parameters.AddWithValue("@hastalik_sebebi", text_hsebebi.Text);
            hastalikkaydet.CommandText = "insert into tbl_hasta(hastalik_adi,hastalik_sebebi)values(@hadi,@sebebi)";
            hastalikkaydet.Connection = eczanebaglanti;
            try
            {
                hastalikkaydet.ExecuteNonQuery();
                pictureBox1.Image = Properties.Resources.onay;
                MessageBox.Show("kayıt işlemi basari ile gerceklesmiştir");
                eczanebaglanti.Close();
               

            }
            
            catch (Exception)
            {
                MessageBox.Show("herhangi bir nedenle bilgilerinize ulasilmamakltadır");
                pictureBox1.Image = Properties.Resources.hata;
                throw;
            }
             eczanebaglanti.Close(); 
        }

        private void but_vazgec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
