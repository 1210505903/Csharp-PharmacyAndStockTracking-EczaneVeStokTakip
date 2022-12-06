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
    public partial class hasta_arama : Form
    {
        public hasta_arama()
        {
            InitializeComponent();
        }
        ilac i = new ilac();                                                                                                         
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void hasta_arama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vt_eczaneDataSet1.tbl_hasta' table. You can move, or remove it, as needed.
            this.tbl_hastaTableAdapter.Fill(this.vt_eczaneDataSet1.tbl_hasta);
            // TODO: This line of code loads data into the 'vt_eczaneDataSet.tbl_hastalik' table. You can move, or remove it, as needed.
            this.tbl_hastalikTableAdapter.Fill(this.vt_eczaneDataSet.tbl_hastalik);
            // TODO: This line of code loads data into the 'vt_eczaneDataSet.tbl_guvence' table. You can move, or remove it, as needed.
            this.tbl_guvenceTableAdapter.Fill(this.vt_eczaneDataSet.tbl_guvence);
            // TODO: This line of code loads data into the 'vt_eczaneDataSet.tbl_hasta' table. You can move, or remove it, as needed.
            this.tbl_hastaTableAdapter.Fill(this.vt_eczaneDataSet.tbl_hasta);

        }
        private void button_ara_Click(object sender, EventArgs e)
        {

        }

        private void text_ara_TextChanged(object sender, EventArgs e)
        {
            if (radio_adi.Checked)
            {
                veritabanieczane vt = new veritabanieczane();
                string eczanekomut = "select * from tbl_hasta where hasta_adi like '" + text_ara.Text + "%'";
                data_hasta.DataSource = vt.dt_olustur(eczanekomut);
                vt.baglantiyi_kapat();
            }
            if (radio_sadi.Checked)
            {
                veritabanieczane vt = new veritabanieczane();
                string eczanekomut = "select * from tbl_hasta where hasta_sadi like '" + text_ara.Text + "%'";
                data_hasta.DataSource = vt.dt_olustur(eczanekomut);
                vt.baglantiyi_kapat();
            }  
            if (radio_tcno.Checked)
            {
                veritabanieczane vt = new veritabanieczane();
                string eczanekomut = "select * from tbl_hasta where hasta_tcno like '" + text_ara.Text + "%'";
                data_hasta.DataSource = vt.dt_olustur(eczanekomut);
                vt.baglantiyi_kapat();   
            }
        }
        private void data_hasta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void data_hasta_DoubleClick(object sender, EventArgs e)
        {
          
        }
        private void data_hasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void data_hasta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_hasta_DoubleClick_1(object sender, EventArgs e)
        {
            int secilen = data_hasta.SelectedCells[0].RowIndex;
            int secilenhastalik = data_hastalik.SelectedCells[0].RowIndex;
            int secilenhast = int.Parse(label3.Text);
            int guvencesatir = int.Parse(label1.Text) - 1;
            i.text_adi.Text = data_hasta.Rows[secilen].Cells[1].Value.ToString();
            i.text_tcno.Text = data_hasta.Rows[secilen].Cells[2].Value.ToString();
            i.text_sadi.Text = data_hasta.Rows[secilen].Cells[3].Value.ToString();
            i.text_dtar.Text = data_hasta.Rows[secilen].Cells[4].Value.ToString();
            i.text_dyeri.Text = data_hasta.Rows[secilen].Cells[5].Value.ToString() + "/" + data_hasta.Rows[secilen].Cells[6].Value.ToString();
            i.text_tel.Text = data_hasta.Rows[secilen].Cells[7].Value.ToString();
            i.label_hastano.Text = data_hasta.Rows[secilen].Cells[0].Value.ToString();
            label1.Text = data_hasta.Rows[secilen].Cells[8].Value.ToString();

            i.text_guvence.Text = data_guvence.Rows[guvencesatir].Cells[1].Value.ToString();
            i.text_hastalik.Text = data_hastalik.Rows[secilenhastalik].Cells[1].Value.ToString();
            i.text_hastaliksebep.Text = data_hastalik.Rows[secilenhastalik].Cells[2].Value.ToString();
            this.Hide();
            i.ShowDialog();
        }
    }
}
