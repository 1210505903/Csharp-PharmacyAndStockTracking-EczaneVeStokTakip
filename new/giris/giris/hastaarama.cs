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
    public partial class hastaarama : Form
    {
        public hastaarama()
        {
            InitializeComponent();
        }
        private void hastaarama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vt_eczaneDataSet.tbl_hasta' table. You can move, or remove it, as needed.
            this.tbl_hastaTableAdapter.Fill(this.vt_eczaneDataSet.tbl_hasta);

        }
    }
}
