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
    public partial class Dersİslem : Form
    {
        public Dersİslem()
        {
            InitializeComponent();
        }
        FinalEntities db = new FinalEntities();
        private void Dersİslem_Load(object sender, EventArgs e)
        {
            cmbegtmn.DisplayMember = "AdSoyad";
            cmbegtmn.ValueMember = "Id";
            cmbegtmn.DataSource = db.Personel.ToList();

            List<ComboBoxDersKredi> list = new List<ComboBoxDersKredi>();
            list.Add(new ComboBoxDersKredi() { ID = "1", Name = "1" });
            list.Add(new ComboBoxDersKredi() { ID = "2", Name = "2" });
            list.Add(new ComboBoxDersKredi() { ID = "3", Name = "3" });
            list.Add(new ComboBoxDersKredi() { ID = "4", Name = "4" });
            list.Add(new ComboBoxDersKredi() { ID = "5", Name = "5" });
            list.Add(new ComboBoxDersKredi() { ID = "6", Name = "6" });
            list.Add(new ComboBoxDersKredi() { ID = "7", Name = "7" });
            list.Add(new ComboBoxDersKredi() { ID = "8", Name = "8" });
            list.Add(new ComboBoxDersKredi() { ID = "9", Name = "9" });
            list.Add(new ComboBoxDersKredi() { ID = "10", Name = "10" });

            cmbkredi.DataSource = list;
            cmbkredi.DisplayMember = "Name";
            cmbkredi.ValueMember = "ID";

            List<ComboBoxDersRenk> list1 = new List<ComboBoxDersRenk>();
            list1.Add(new ComboBoxDersRenk() { ID = "1", Name = "Siyah" });
            list1.Add(new ComboBoxDersRenk() { ID = "2", Name = "Beyaz" });
            list1.Add(new ComboBoxDersRenk() { ID = "3", Name = "Kırmızı" });
            list1.Add(new ComboBoxDersRenk() { ID = "4", Name = "Yeşil" });
            list1.Add(new ComboBoxDersRenk() { ID = "5", Name = "Sarı" });
            list1.Add(new ComboBoxDersRenk() { ID = "6", Name = "Mavi" });
            list1.Add(new ComboBoxDersRenk() { ID = "7", Name = "Pembe" });
            list1.Add(new ComboBoxDersRenk() { ID = "8", Name = "Gri" });
            list1.Add(new ComboBoxDersRenk() { ID = "9", Name = "Kahverengi" });
            list1.Add(new ComboBoxDersRenk() { ID = "10", Name = "Turuncu" });
            list1.Add(new ComboBoxDersRenk() { ID = "11", Name = "Mor" });

            cmbrenk.DataSource = list1;
            cmbrenk.DisplayMember = "Name";
            cmbrenk.ValueMember = "ID";
        }

        private void Ekle_buton_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            ders.Ders_Adı = dersad.Text;
            ders.Ders_Kredisi = int.Parse(cmbkredi.SelectedValue.ToString());
            ders.Okul_Yönetim_Id = int.Parse(cmbegtmn.SelectedValue.ToString());
            ders.Ders_Rengi = int.Parse(cmbrenk.SelectedValue.ToString());
            db.Ders.Add(ders);
            db.SaveChanges();
            MessageBox.Show("Ders Eklendi");
        }

        private void Güncelle_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var drs = db.Ders.Find(x);
            drs.Ders_Adı = dersad.Text;
            drs.Ders_Kredisi = int.Parse(cmbkredi.SelectedValue.ToString());
            drs.Okul_Yönetim_Id = int.Parse(cmbegtmn.SelectedValue.ToString());
            drs.Ders_Rengi = int.Parse(cmbrenk.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ders Güncellendi");
        }

        private void Sil_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var drs = db.Ders.Find(x);
            db.Ders.Remove(drs);
            db.SaveChanges();
            MessageBox.Show("Ders Silindi");
        }
        internal class ComboBoxDersRenk
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }

        internal class ComboBoxDersKredi
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
    }
}
