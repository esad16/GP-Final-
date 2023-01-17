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
    public partial class OgrenciDersListele : Form
    {
        public OgrenciDersListele()
        {
            InitializeComponent();
        }

        FinalEntities db = new FinalEntities();

        private void OgrenciDersListele_Load(object sender, EventArgs e)
        {
            List<ComboBoxFiltre> list = new List<ComboBoxFiltre>();
            list.Add(new ComboBoxFiltre() { ID = "1", Name = "Öğrenci Ad" });
            list.Add(new ComboBoxFiltre() { ID = "2", Name = "Ders Ad" });
            list.Add(new ComboBoxFiltre() { ID = "3", Name = "Tümü" });

            cmbfiltre.DataSource = list;
            cmbfiltre.DisplayMember = "Name";
            cmbfiltre.ValueMember = "ID";

            List<ComboBoxFiltre> list1 = new List<ComboBoxFiltre>();

            list1.Add(new ComboBoxFiltre() { ID = "1", Name = "Öğrenci Ad" });
            list1.Add(new ComboBoxFiltre() { ID = "2", Name = "Ders Ad" });

            cmbdeğer.DataSource = list1;
            cmbdeğer.DisplayMember = "Name";
            cmbdeğer.ValueMember = "ID";

            List<ComboBoxFiltre> list2 = new List<ComboBoxFiltre>();

            list2.Add(new ComboBoxFiltre() { ID = "1", Name = "A-Z" });
            list2.Add(new ComboBoxFiltre() { ID = "2", Name = "Z-A" });

            cmbşekil.DataSource = list2;
            cmbşekil.DisplayMember = "Name";
            cmbşekil.ValueMember = "ID";

            dataGridViewDers.DataSource = (from x in db.OgrenciDers
                                             select new
                                             {
                                                 x.Id,
                                                 x.Ogrenci.Ad_Soyad,
                                                 x.Ders.Ders_Adı,


                                             }).ToList();
        }

        private void Yenile_btn_Click(object sender, EventArgs e)
        {
            dataGridViewDers.DataSource = (from x in db.OgrenciDers
                                           select new
                                           {
                                               x.Id,
                                               x.Ogrenci.Ad_Soyad,
                                               x.Ders.Ders_Adı,


                                           }).ToList();
        }

        private void Ara_txt_TextChanged(object sender, EventArgs e)
        {
            string aranan = Ara_txt.Text;
            if (cmbfiltre.Text == "Öğrenci Ad")
            {
                var degerler = from item in db.OgrenciDers
                               where item.Ogrenci.Ad_Soyad.Contains(aranan)
                               select new { item.Ogrenci.Ad_Soyad, item.Ders.Ders_Adı };
                dataGridViewDers.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Ders Ad")
            {
                var degerler = from item in db.OgrenciDers
                               where item.Ders.Ders_Adı.Contains(aranan)
                               select new { item.Ogrenci.Ad_Soyad, item.Ders.Ders_Adı };
                dataGridViewDers.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Tümü")
            {
                var degerler = from item in db.OgrenciDers
                               where item.Ogrenci.Ad_Soyad.Contains(aranan) || item.Ders.Ders_Adı.Contains(aranan)
                               select new { item.Ogrenci.Ad_Soyad, item.Ders.Ders_Adı };
                dataGridViewDers.DataSource = degerler.ToList();
            }
        }

        private void btnsırala_Click(object sender, EventArgs e)
        {
            var data = (from x in db.OgrenciDers
                        select new
                        {
                            x.Id,
                            x.Ogrenci.Ad_Soyad,
                            x.Ders.Ders_Adı,
                        }).ToList();
            if (cmbşekil.Text == "A-Z" && cmbfiltre.Text == "Öğrenci Ad")
            {
                data = data.OrderBy(x => x.Ad_Soyad).ToList();
            }
            else if (cmbşekil.Text == "A-Z" && cmbfiltre.Text == "Ders Ad")
            {
                data = data.OrderBy(x => x.Ders_Adı).ToList();
            }
            else if (cmbşekil.Text == "Z-A" && cmbfiltre.Text == "Öğrenci Ad")
            {
                data = data.OrderByDescending(x => x.Ad_Soyad).ToList();
            }
            else if (cmbşekil.Text == "Z-A" && cmbfiltre.Text == "Ders Ad")
            {
                data = data.OrderByDescending(x => x.Ders_Adı).ToList();
            }
            dataGridViewDers.DataSource = data;
        }

        private void dataGridViewDers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewDers.SelectedCells[0].RowIndex;
            OgrenciDersİslemleri ögr_drs = new OgrenciDersİslemleri();

            ögr_drs.labelId.Text = dataGridViewDers.Rows[selected].Cells[0].Value.ToString();
            ögr_drs.cmböğrid.Text = dataGridViewDers.Rows[selected].Cells[1].Value.ToString();
            ögr_drs.cmbdersid.Text = dataGridViewDers.Rows[selected].Cells[2].Value.ToString();


            ögr_drs.MdiParent = this.MdiParent;
            ögr_drs.Show();
        }
    }
}
