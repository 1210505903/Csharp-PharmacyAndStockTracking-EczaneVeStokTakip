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
    public partial class ilac : Form
    {
        public ilac()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=vt_eczane.accdb");
        private void ilac_Load(object sender, EventArgs e)
        {
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void toolStrip3_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hasta_arama h = new hasta_arama();
            this.Hide();
            h.Show();
        }
        private void data_ilac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void radio_var_CheckedChanged(object sender, EventArgs e)
        {
            int hastano = int.Parse(label_hastano.Text);
            if (radio_var.Checked)
            {
                panel_rapor.Visible = true;
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from tbl_rapor");
                komut.Connection = baglanti;
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (oku[5].ToString()==label_hastano.Text)
                    {
                        label_rapornedeni.Text = oku[1].ToString();
                        label_raporbastar.Text = oku[2].ToString();
                        label_raporbittar.Text = oku[3].ToString();
                        list_raporilac.Items.Add(oku[4].ToString());
                    }
                }
                oku.Close();
                baglanti.Close();
            }
        }
        private void radio_yok_CheckedChanged(object sender, EventArgs e)
        {
            panel_rapor.Visible = false;
        }
        private void label_rapornedeni_Click(object sender, EventArgs e)
        {
        }

        private void list_raporilac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void text_ilacara_TextChanged(object sender, EventArgs e)
        {
            veritabanieczane vt = new veritabanieczane();
            string eczanekomut = "select * from tbl_ilac where hasta_adi like '" + text_ilacara.Text + "%'";
            data_ilac.DataSource = vt.dt_olustur(eczanekomut);
            vt.baglantiyi_kapat();
        }
    }
}
