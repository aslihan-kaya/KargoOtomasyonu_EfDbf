using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoOtomasyonu_EfDbf
{
    public partial class Arac : Form
    {
        public Arac()
        {
            InitializeComponent();
        }

        private void polikliniklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri go = new Musteri();
            go.Show();
            this.Hide();
        }

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Arac go = new Arac();
            go.Show();
            this.Hide();

        }

        private void hastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sevkiyat go = new Sevkiyat();
            go.Show();
            this.Hide();
        }
    }
}
