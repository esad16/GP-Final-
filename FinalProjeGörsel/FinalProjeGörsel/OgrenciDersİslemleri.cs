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
    public partial class OgrenciDersİslemleri : Form
    {
        public OgrenciDersİslemleri()
        {
            InitializeComponent();
        }

        FinalEntities db = new FinalEntities();
        private void OgrenciDersİslemleri_Load(object sender, EventArgs e)
        {
            cmbdersid.DisplayMember = "Ders_Adı";
            cmbdersid.ValueMember = "ID";

            cmböğrid.DisplayMember = "Ad_Soyad";
            cmböğrid.ValueMember = "ID";

            cmbdersid.DataSource = db.Ders.ToList();
            cmböğrid.DataSource = db.Ogrenci.ToList();
        }

        private void Ekle_buton_Click(object sender, EventArgs e)
        {
            OgrenciDers ögrdrs = new OgrenciDers();
            ögrdrs.Ogrenci_Id = int.Parse(cmböğrid.SelectedValue.ToString());
            ögrdrs.Ders_Id = int.Parse(cmbdersid.SelectedValue.ToString());
            db.OgrenciDers.Add(ögrdrs);
            db.SaveChanges();
            MessageBox.Show("Öğrenciye Ders İliştirildi");
        }

        private void Güncelle_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var ögrdrs = db.OgrenciDers.Find(x);
            ögrdrs.Ogrenci_Id = int.Parse(cmböğrid.SelectedValue.ToString());
            ögrdrs.Ders_Id = int.Parse(cmbdersid.SelectedValue.ToString());
            MessageBox.Show("Öğrencinin Dersi Güncellendi");
        }

        private void Sil_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var ögrdrs = db.OgrenciDers.Find(x);
            db.OgrenciDers.Remove(ögrdrs);
            db.SaveChanges();
            MessageBox.Show("Ders Silindi");
        }
    }
}
