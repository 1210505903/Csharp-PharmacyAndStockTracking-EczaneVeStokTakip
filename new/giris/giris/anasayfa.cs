using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giris
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastakayit h = new hastakayit();
            this.Hide();
            h.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hastalikekle h = new hastalikekle();
            this.Hide();
            h.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fırma_ekle f = new fırma_ekle();
            this.Hide();
            f.Show();
        }
    }
}
