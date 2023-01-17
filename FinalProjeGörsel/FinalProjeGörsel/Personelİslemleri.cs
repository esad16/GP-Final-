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
    public partial class Personelİslemleri : Form
    {
        public Personelİslemleri()
        {
            InitializeComponent();
        }

        FinalEntities db = new FinalEntities();
        private void Personelİslemleri_Load(object sender, EventArgs e)
        {
            List<ComboBoxYonetimTip> list = new List<ComboBoxYonetimTip>();
            list.Add(new ComboBoxYonetimTip() { ID = "11", Name = "İdare" });
            list.Add(new ComboBoxYonetimTip() { ID = "12", Name = "Öğretmen" });
            list.Add(new ComboBoxYonetimTip() { ID = "13", Name = "Öğrenciİşleri" });

            departcmb.DataSource = list;
            departcmb.DisplayMember = "Name";
            departcmb.ValueMember = "ID";
        }

        private void Ekle_buton_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Ad_Soyad = txtAd.Text;
            personel.Görevi = txtGörevi.Text;
            personel.Yönetim_Tipi = int.Parse(departcmb.SelectedValue.ToString());
            db.Personel.Add(personel);
            db.SaveChanges();
            MessageBox.Show("Personel Eklendi");
        }

        private void Güncelle_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var personel = db.Personel.Find(x);
            personel.Ad_Soyad = txtAd.Text;
            personel.Görevi = txtGörevi.Text;
            personel.Yönetim_Tipi = int.Parse(departcmb.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Personel Güncellendi");
        }

        private void Sil_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var personel = db.Personel.Find(x);
            db.Personel.Remove(personel);
            db.SaveChanges();
            MessageBox.Show("Personel Silindi");
        }

        internal class ComboBoxYonetimTip
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
    }
}
