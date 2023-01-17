using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProjeGörsel.PersonelListele;

namespace FinalProjeGörsel
{
    public partial class DersListele : Form
    {
        public DersListele()
        {
            InitializeComponent();
        }

        private void DersListele_Load(object sender, EventArgs e)
        {
            List<ComboBoxFiltre> list = new List<ComboBoxFiltre>();
            list.Add(new ComboBoxFiltre() { ID = "1", Name = "Ders Ad" });
            list.Add(new ComboBoxFiltre() { ID = "2", Name = "Ders Kredi" });
            list.Add(new ComboBoxFiltre() { ID = "3", Name = "Eğitmen" });
            list.Add(new ComboBoxFiltre() { ID = "4", Name = "Renk" });
            list.Add(new ComboBoxFiltre() { ID = "5", Name = "Tümü" });

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

            cmbşekil.DataSource = list2;
            cmbşekil.DisplayMember = "Name";
            cmbşekil.ValueMember = "ID";

            dataGridViewDers.DataSource = (from x in db.Ders
                                           select new
                                           {
                                               x.Id,
                                               x.Ders_Adı,
                                               x.Ders_Kredisi,
                                               x.Personel.Ad_Soyad,
                                               x.Ders_Rengi

                                           }).ToList();
        }

        FinalEntities db = new FinalEntities();
        private void Ara_txt_TextChanged(object sender, EventArgs e)
        {
            string aranan = Ara_txt.Text;
            if (cmbfiltre.Text == "Ders Ad")
            {
                var degerler = from item in db.Ders
                               where item.Ders_Adı.Contains(aranan)
                               select new { item.Ders_Adı, item.Ders_Kredisi, item.Personel.Ad_Soyad, item.Ders_Rengi };
                dataGridViewDers.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Ders Kredi")
            {
                var degerler = from item in db.Ders
                               where item.Ders_Kredisi.ToString().Contains(aranan)
                               select new { item.Ders_Adı, item.Ders_Kredisi, item.Personel.Ad_Soyad, item.Ders_Rengi };
                dataGridViewDers.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Eğitmen")
            {
                var degerler = from item in db.Ders
                               where item.Personel.Ad_Soyad.Contains(aranan)
                               select new { item.Ders_Adı, item.Ders_Kredisi, item.Personel.Ad_Soyad, item.Ders_Rengi };
                dataGridViewDers.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Renk")
            {
                var degerler = from item in db.Ders
                               where item.Ders_Rengi.ToString().Contains(aranan)
                               select new { item.Ders_Adı, item.Ders_Kredisi, item.Personel.Ad_Soyad, item.Ders_Rengi };
                dataGridViewDers.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Tümü")
            {
                var degerler = from item in db.Ders
                               where item.Ders_Adı.Contains(aranan) || item.Ders_Kredisi.ToString().Contains(aranan) || item.Personel.Ad_Soyad.Contains(aranan) || item.Ders_Rengi.ToString().Contains(aranan)
                               select new { item.Ders_Adı, item.Ders_Kredisi, item.Personel.Ad_Soyad, item.Ders_Rengi };
                dataGridViewDers.DataSource = degerler.ToList();
            }
        }

        private void dataGridViewDers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewDers.SelectedCells[0].RowIndex;
            Dersİslem ders_İşlemleri = new Dersİslem();

            ders_İşlemleri.labelId.Text = dataGridViewDers.Rows[selected].Cells[0].Value.ToString();
            ders_İşlemleri.dersad.Text = dataGridViewDers.Rows[selected].Cells[1].Value.ToString();
            ders_İşlemleri.cmbkredi.Text = dataGridViewDers.Rows[selected].Cells[2].Value.ToString();
            ders_İşlemleri.cmbegtmn.Text = dataGridViewDers.Rows[selected].Cells[3].Value.ToString();
            ders_İşlemleri.cmbrenk.Text = dataGridViewDers.Rows[selected].Cells[4].Value.ToString();

            ders_İşlemleri.MdiParent = this.MdiParent;
            ders_İşlemleri.Show();
        }

        private void Yenile_btn_Click(object sender, EventArgs e)
        {
            dataGridViewDers.DataSource = (from x in db.Ders
                                           select new
                                           {
                                               x.Id,
                                               x.Ders_Adı,
                                               x.Ders_Kredisi,
                                               x.Personel.Ad_Soyad,
                                               x.Ders_Rengi

                                           }).ToList();
        }

        private void btnsırala_Click(object sender, EventArgs e)
        {
            var data = (from x in db.Ders
                        select new
                        {
                            x.Id,
                            x.Ders_Adı,
                            x.Ders_Kredisi,
                            x.Personel.Ad_Soyad,
                            x.Ders_Rengi
                        }).ToList();
            if (cmbşekil.Text == "A-Z")
            {
                data = data.OrderBy(x => x.Ders_Adı).ToList();
            }
            else if (cmbşekil.Text == "Z-A")
            {
                data = data.OrderByDescending(x => x.Ders_Adı).ToList();
            }
            dataGridViewDers.DataSource = data;
        }

        private void dataGridViewDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
