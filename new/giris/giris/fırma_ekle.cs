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
    public partial class fırma_ekle : Form
    {
        public fırma_ekle()
        {
            InitializeComponent();
        }
        OleDbConnection sehirbaglanti = new OleDbConnection("Provider= Microsoft.Jet.Oledb.4.0;Data Source=" + Application.StartupPath + "//sehirler.mdb");
        OleDbConnection eczanebaglantı = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "//vt_eczane.accdb"); 
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void fırma_ekle_Load(object sender, EventArgs e)
        {
            sehirbaglanti.Open();
            OleDbDataAdapter sehir = new OleDbDataAdapter("select * from sehir", sehirbaglanti);
            DataTable sehirtablosu = new DataTable();
            sehir.Fill(sehirtablosu);
            combo_il.DisplayMember = "iladi";//görüntülenecek alan
            combo_il.ValueMember = "ilno";
            combo_il.DataSource = sehirtablosu;
            OleDbDataAdapter ulkeler = new OleDbDataAdapter("select * from ekzen ", sehirbaglanti);
            DataTable ulkelertablosu = new DataTable();
            ulkeler.Fill(ulkelertablosu);
            combo_ulke.DisplayMember = "Ulke";
            combo_ulke.DataSource = ulkelertablosu;
           
            sehirbaglanti.Close();

            for (int i = 500; i < 550; i++)
            {
                combo_tel.Items.Add(i);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ilno = combo_il.SelectedValue.ToString();
            OleDbDataAdapter ilceler = new OleDbDataAdapter("select * from ilceler where ilno=" + ilno, sehirbaglanti);
            DataTable sehirtablosu = new DataTable();
            ilceler.Fill(sehirtablosu);
            combo_ilce.DisplayMember = "ilceadi";//görüntüleme kodu.
            combo_ilce.ValueMember = "ilno";
            combo_ilce.DataSource = sehirtablosu;
            sehirbaglanti.Close();
        }

        private void combo_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            eczanebaglantı.Open();
            OleDbCommand firmakaydet = new OleDbCommand();
            string tel = combo_tel.SelectedItem.ToString() + text_tel.Text;
            string adres = text_adres.Text + combo_il.Text + "/" + combo_ilce.Text;
            firmakaydet.Parameters.AddWithValue("@fadi", text_fadi.Text);
             firmakaydet.Parameters.AddWithValue("@ftel", tel);
             firmakaydet.Parameters.AddWithValue("@mail", text_mail.Text);
             firmakaydet.Parameters.AddWithValue("@ulke", combo_ulke.Text);
             firmakaydet.Parameters.AddWithValue("@fyer",adres);
             firmakaydet.CommandText = "insert into tbl_firma(firma_adi,firma_adres,firma_tel,firma_email,firma_mensei)values(@fadi,@fyer,@ftel,@mail,@ulke)";
             firmakaydet.Connection = eczanebaglantı;
             firmakaydet.ExecuteNonQuery();
             eczanebaglantı.Close();
        }
    }
}
