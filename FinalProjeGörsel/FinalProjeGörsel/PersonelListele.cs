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
    public partial class PersonelListele : Form
    {
        public PersonelListele()
        {
            InitializeComponent();
        }

        FinalEntities db = new FinalEntities();
        private void PersonelListele_Load(object sender, EventArgs e)
        {
            List<ComboBoxFiltre> list = new List<ComboBoxFiltre>();

            list.Add(new ComboBoxFiltre() { ID = "1", Name = "İsim" });
            list.Add(new ComboBoxFiltre() { ID = "2", Name = "Görev" });
            list.Add(new ComboBoxFiltre() { ID = "3", Name = "Departman" });
            list.Add(new ComboBoxFiltre() { ID = "4", Name = "Tümü" });

            cmbfiltre.DataSource = list;
            cmbfiltre.DisplayMember = "Name";
            cmbfiltre.ValueMember = "ID";

            List<ComboBoxFiltre> list1 = new List<ComboBoxFiltre>();

            list1.Add(new ComboBoxFiltre() { ID = "1", Name = "Ad-Soyad" });

            cmbdeğer.DataSource = list1;
            cmbdeğer.DisplayMember = "Name";
            cmbdeğer.ValueMember = "ID";

            List<ComboBoxFiltre> list2 = new List<ComboBoxFiltre>();

            list2.Add(new ComboBoxFiltre() { ID = "1", Name = "A-Z" });
            list2.Add(new ComboBoxFiltre() { ID = "2", Name = "Z-A" });

            sıralamacmb.DataSource = list2;
            sıralamacmb.DisplayMember = "Name";
            sıralamacmb.ValueMember = "ID";

            dataGridViewPers.DataSource = (from x in db.Personel
                                           select new
                                           {
                                               x.Id,
                                               x.Ad_Soyad,
                                               x.Görevi,
                                               x.Yönetim_Tipi
                                           }).ToList();
        }

        internal class ComboBoxFiltre
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }

        private void dataGridViewPers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewPers.SelectedCells[0].RowIndex;
            Personelİslemleri personel = new Personelİslemleri();

            personel.labelId.Text = dataGridViewPers.Rows[selected].Cells[0].Value.ToString();
            personel.txtAd.Text = dataGridViewPers.Rows[selected].Cells[1].Value.ToString();
            personel.txtGörevi.Text = dataGridViewPers.Rows[selected].Cells[2].Value.ToString();
            personel.departcmb.Text = dataGridViewPers.Rows[selected].Cells[3].Value.ToString();

            personel.MdiParent = this.MdiParent;
            personel.Show();
        }

        private void Yenile_btn_Click(object sender, EventArgs e)
        {
            dataGridViewPers.DataSource = (from x in db.Personel
                                           select new
                                           {
                                               x.Id,
                                               x.Ad_Soyad,
                                               x.Görevi,
                                               x.Yönetim_Tipi
                                           }).ToList();
        }

        private void Ara_txt_TextChanged(object sender, EventArgs e)
        {
            string aranan = Ara_txt.Text;
            if (cmbfiltre.Text == "İsim")
            {
                var degerler = from item in db.Personel
                               where item.Ad_Soyad.Contains(aranan)
                               select new { item.Ad_Soyad, item.Görevi, item.Yönetim_Tipi };
                dataGridViewPers.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Görev")
            {
                var degerler = from item in db.Personel
                               where item.Görevi.Contains(aranan)
                               select new { item.Ad_Soyad, item.Görevi, item.Yönetim_Tipi };
                dataGridViewPers.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Departman")
            {
                var degerler = from item in db.Personel
                               where item.Yönetim_Tipi.ToString().Contains(aranan)
                               select new { item.Ad_Soyad, item.Görevi, item.Yönetim_Tipi };
                dataGridViewPers.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Tümü")
            {
                var degerler = from item in db.Personel
                               where item.Ad_Soyad.Contains(aranan) || item.Görevi.Contains(aranan) || item.Yönetim_Tipi.ToString().Contains(aranan)
                               select new { item.Ad_Soyad, item.Görevi, item.Yönetim_Tipi };
                dataGridViewPers.DataSource = degerler.ToList();
            }
        }

        private void Srlbtn_Click(object sender, EventArgs e)
        {
            var data = (from x in db.Personel
                        select new
                        {
                            x.Id,
                            x.Ad_Soyad,
                            x.Görevi,
                            x.Yönetim_Tipi
                        }).ToList();
            if (sıralamacmb.Text == "A-Z")
            {
                data = data.OrderBy(x => x.Ad_Soyad).ToList();
            }
            else if (sıralamacmb.Text == "Z-A")
            {
                data = data.OrderByDescending(x => x.Ad_Soyad).ToList();
            }
            dataGridViewPers.DataSource = data;
        }
    }
}
