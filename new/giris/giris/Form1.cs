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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "\\vt_eczane.accdb");
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand tablosecimi = new OleDbCommand("select * from tbl_kullanici", baglanti);
            OleDbDataReader okuyucu = tablosecimi.ExecuteReader();
            while (okuyucu.Read())
            {
                if ((okuyucu[1].ToString() == textBox1.Text) && (textBox2.Text == okuyucu[2].ToString()))
                {
                    this.Hide();
                    Form2 f = new Form2();
                    f.Show();
                }
            }
            okuyucu.Close();
            baglanti.Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kullanicikayit k = new kullanicikayit();
            k.Show();
        }
    }
}
