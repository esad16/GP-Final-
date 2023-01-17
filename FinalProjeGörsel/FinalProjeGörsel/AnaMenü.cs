using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjeGörsel
{
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListele ekle = new OgrenciListele();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void öğrenciEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenciİslem ekle = new Ogrenciİslem();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void öğrenciDersEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciDersİslemleri ekle = new OgrenciDersİslemleri();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void öğrenciDersleriniListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciDersListele ekle = new OgrenciDersListele();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personelİslemleri ekle = new Personelİslemleri();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void personelListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListele ekle = new PersonelListele();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void dersDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dersİslem ekle = new Dersİslem();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void dersleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersListele ekle = new DersListele();
            ekle.MdiParent = this;
            ekle.Show();
        }
    }
}
