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
    public partial class OgrenciListele : Form
    {
        public OgrenciListele()
        {
            InitializeComponent();
        }

        FinalEntities db= new FinalEntities();
        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            List<ComboBoxFiltre> list = new List<ComboBoxFiltre>();
            list.Add(new ComboBoxFiltre() { ID = "1", Name = "Ad-Soyad" });
            list.Add(new ComboBoxFiltre() { ID = "2", Name = "Öğrenci No" });
            list.Add(new ComboBoxFiltre() { ID = "3", Name = "Bölüm" });
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

            cmbşekil.DataSource = list2;
            cmbşekil.DisplayMember = "Name";
            cmbşekil.ValueMember = "ID";

            dataGridViewOgr.DataSource = (from x in db.Ogrenci
                                          select new
                                          {
                                              x.Id,
                                              x.Ad_Soyad,
                                              x.Kayıt_Tarihi,
                                              x.Öğrenci_No,
                                              x.Doğum_Tarihi,
                                              x.Bölümü
                                          }).ToList();
        }

        private void Yenile_btn_Click(object sender, EventArgs e)
        {
            string aranan = Ara_txt.Text;
            if (cmbfiltre.Text == "Ad-Soyad")
            {
                var degerler = from item in db.Ogrenci
                               where item.Ad_Soyad.Contains(aranan)
                               select new { item.Ad_Soyad, item.Öğrenci_No, item.Bölümü };
                dataGridViewOgr.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Öğrenci No")
            {
                var degerler = from item in db.Ogrenci
                               where item.Öğrenci_No.Contains(aranan)
                               select new { item.Ad_Soyad, item.Öğrenci_No, item.Bölümü };
                dataGridViewOgr.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Bölüm")
            {
                var degerler = from item in db.Ogrenci
                               where item.Bölümü.ToString().Contains(aranan)
                               select new { item.Ad_Soyad, item.Öğrenci_No, item.Bölümü };
                dataGridViewOgr.DataSource = degerler.ToList();
            }
            if (cmbfiltre.Text == "Tümü")
            {
                var degerler = from item in db.Ogrenci
                               where item.Ad_Soyad.Contains(aranan) || item.Öğrenci_No.Contains(aranan) || item.Bölümü.ToString().Contains(aranan)
                               select new { item.Ad_Soyad, item.Öğrenci_No, item.Bölümü };
                dataGridViewOgr.DataSource = degerler.ToList();
            }
        }

        private void btnsırala_Click(object sender, EventArgs e)
        {
            var data = (from x in db.Ogrenci
                        select new
                        {
                            x.Id,
                            x.Ad_Soyad,
                            x.Kayıt_Tarihi,
                            x.Öğrenci_No,
                            x.Doğum_Tarihi,
                            x.Bölümü
                        }).ToList();
            if (cmbşekil.Text == "A-Z")
            {
                data = data.OrderBy(x => x.Ad_Soyad).ToList();
            }
            else if (cmbşekil.Text == "Z-A")
            {
                data = data.OrderByDescending(x => x.Ad_Soyad).ToList();
            }
            dataGridViewOgr.DataSource = data;
        }

        private void dataGridViewOgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewOgr.SelectedCells[0].RowIndex;
            Ogrenciİslem öğrenci = new Ogrenciİslem();

            öğrenci.labelId.Text = dataGridViewOgr.Rows[selected].Cells[0].Value.ToString();
            öğrenci.adSoyadtxt.Text = dataGridViewOgr.Rows[selected].Cells[1].Value.ToString();
            öğrenci.kytTrh.Text = dataGridViewOgr.Rows[selected].Cells[2].Value.ToString();
            öğrenci.nmrtxt.Text = dataGridViewOgr.Rows[selected].Cells[3].Value.ToString();
            öğrenci.Dgmtrh.Text = dataGridViewOgr.Rows[selected].Cells[4].Value.ToString();
            öğrenci.Bölümcmb.Text = dataGridViewOgr.Rows[selected].Cells[5].Value.ToString();

            öğrenci.MdiParent = this.MdiParent;
            öğrenci.Show();
        }
    }
}
