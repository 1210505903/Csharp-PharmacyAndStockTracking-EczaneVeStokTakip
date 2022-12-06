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
    public partial class hastakayit : Form
    {
        public hastakayit()
        {
            InitializeComponent();
        }
        OleDbConnection sehirbaglanti = new OleDbConnection("Provider= Microsoft.Jet.Oledb.4.0;Data Source=" + Application.StartupPath + "//sehirler.mdb");
        OleDbConnection eczanebaglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "//vt_eczane.accdb"); 
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void hastakayit_Load(object sender, EventArgs e)
        {
            sehirbaglanti.Open();
            OleDbDataAdapter sehir = new OleDbDataAdapter("select * from sehir",sehirbaglanti) ;
            DataTable sehirtablosu = new DataTable();
            sehir.Fill(sehirtablosu);
            combo_hil.DisplayMember = "iladi";//görüntülenecek alan
            combo_hil.ValueMember = "ilno";
            combo_hil.DataSource = sehirtablosu;
            sehirbaglanti.Close();

            eczanebaglanti.Open();
            OleDbDataAdapter sosyal = new OleDbDataAdapter("select * from tbl_guvence", eczanebaglanti);
            DataTable guvencetablosu = new DataTable();
            sosyal.Fill(guvencetablosu);
            combo_guvence.DisplayMember = "guvence";
            combo_guvence.ValueMember = "guvence_id";
            combo_guvence.DataSource = guvencetablosu;
            eczanebaglanti.Close();
            for (int i = 500; i < 550; i++)
            {
                combo_htel.Items.Add(i);
            }
      
        }
        private void combo_hil_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ilno = combo_hil.SelectedValue.ToString();
            OleDbDataAdapter ilceler = new OleDbDataAdapter("select * from ilceler where ilno=" + ilno, sehirbaglanti);
            DataTable sehirtablosu = new DataTable();
            ilceler.Fill(sehirtablosu);
            combo_ilce.DisplayMember = "ilceadi";//görüntüleme kodu.
            combo_ilce.ValueMember = "ilno";
            combo_ilce.DataSource = sehirtablosu;
            sehirbaglanti.Close();

        }

        private void but_kaydet_Click(object sender, EventArgs e)
        {
            string dogtar=dateTimePicker1.Text;
            
            eczanebaglanti.Open();
            OleDbCommand hastakaydet = new OleDbCommand();
            hastakaydet.Connection = eczanebaglanti;
            hastakaydet.Parameters.AddWithValue("@hastaadi", text_hadi.Text);
            hastakaydet.Parameters.AddWithValue("@hastasoyadi", text_hsadi.Text);
            hastakaydet.Parameters.AddWithValue("@hastatcno", text_tc.Text);
            hastakaydet.Parameters.AddWithValue("@hasdogtar", dogtar);
            hastakaydet.Parameters.AddWithValue("@il", combo_hil.SelectedItem.ToString());
            hastakaydet.Parameters.AddWithValue("@ilce", combo_ilce.SelectedItem.ToString());
            hastakaydet.Parameters.AddWithValue("@guvenceno", int.Parse(combo_guvence.SelectedValue.ToString()));
            hastakaydet.Parameters.AddWithValue("@telefon", combo_htel.Text + text_htel.Text);
            hastakaydet.CommandText = "İnsert İnto tbl_hasta(hasta_adi,hasta_sadi,hasta_tcno,hasta_dogumt,dogumyeri_il,dogumyeri_ilce,guvence_no,telefon_no)values(@hastaadi,@hastasoyadi,@hastasoyadi,@hasdogtar,@il,@ilce,@guvenceno,@telefon)";
        }

        private void but_vazgec_Click(object sender, EventArgs e)
        {
         
        }
    }
}
