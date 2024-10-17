using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kopyala");
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geri Al");
        }

        private void ileriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İleri Al");
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapıştır ");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz ?","Uyarı !!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (sonuc==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
