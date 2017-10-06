using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class Kiralamalar : Form
    {
        public Kiralamalar()
        {
            InitializeComponent();
        }
        Ayarlar ayarlar = new Ayarlar();
        private void Kiralamalar_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            kirada_listele();
            gecmis_listele();
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void gecmis_listele()
        {
            lvGecmis.Items.Clear();
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kiralama inner join araba on kiralama.araba_id = araba.a_id inner join musteri on kiralama.musteri_id = musteri.m_id inner join personel on kiralama.personel_id = personel.p_id order by k_id desc", conn);
            SqlDataReader oku = komut.ExecuteReader();

            ImageList ResimListe = new ImageList();
            ResimListe.ImageSize = new Size(64, 64);

            while (oku.Read())
            {
                int sira = lvGecmis.Items.Count;
                ResimListe.Images.Add(Image.FromFile(@oku["a_resim"].ToString().Trim()));
                lvGecmis.SmallImageList = ResimListe;
                lvGecmis.Items.Add(oku["a_id"].ToString().Trim(), sira);

                lvGecmis.Items[sira].Tag = oku["k_id"].ToString().Trim();


                lvGecmis.Items[sira].SubItems.Add(oku["m_adi"].ToString().Trim() + " " + oku["m_soyadi"].ToString().Trim());
                lvGecmis.Items[sira].SubItems.Add(oku["bas_tarih"].ToString().Trim());
                lvGecmis.Items[sira].SubItems.Add(oku["bit_tarih"].ToString().Trim());
                lvGecmis.Items[sira].SubItems.Add(oku["p_adisoyadi"].ToString().Trim());
                lvGecmis.Items[sira].SubItems.Add(oku["toplam_tutar"].ToString().Trim() + "₺");
            }
            conn.Close();
        }

        private void kirada_listele()
        {
            lvKiradakiler.Items.Clear();
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kiralama inner join araba on kiralama.araba_id = araba.a_id inner join musteri on kiralama.musteri_id = musteri.m_id inner join personel on kiralama.personel_id = personel.p_id order by k_id desc", conn);
            SqlDataReader oku = komut.ExecuteReader();

            ImageList ResimListe = new ImageList();
            ResimListe.ImageSize = new Size(64, 64);

            while (oku.Read())
            {
                DateTime bitis = Convert.ToDateTime(oku["bit_tarih"].ToString().Trim());
                if (DateTime.Now < bitis)
                {
                    int sira = lvKiradakiler.Items.Count;
                    ResimListe.Images.Add(Image.FromFile(@oku["a_resim"].ToString().Trim()));
                    lvKiradakiler.SmallImageList = ResimListe;
                    lvKiradakiler.Items.Add(oku["a_id"].ToString().Trim(), sira);

                    lvKiradakiler.Items[sira].Tag = oku["k_id"].ToString().Trim();

                    lvKiradakiler.Items[sira].SubItems.Add(oku["m_adi"].ToString().Trim() + " " + oku["m_soyadi"].ToString().Trim());
                    lvKiradakiler.Items[sira].SubItems.Add(oku["bas_tarih"].ToString().Trim());
                    lvKiradakiler.Items[sira].SubItems.Add(oku["bit_tarih"].ToString().Trim());
                    lvKiradakiler.Items[sira].SubItems.Add(oku["p_adisoyadi"].ToString().Trim());
                    lvKiradakiler.Items[sira].SubItems.Add(oku["toplam_tutar"].ToString().Trim() + "₺"); 
                }
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lvGecmis.Items.Clear();
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kiralama inner join araba on kiralama.araba_id = araba.a_id inner join musteri on kiralama.musteri_id = musteri.m_id inner join personel on kiralama.personel_id = personel.p_id order by k_id desc", conn);
            SqlDataReader oku = komut.ExecuteReader();

            ImageList ResimListe = new ImageList();
            ResimListe.ImageSize = new Size(64, 64);

            while (oku.Read())
            {
                DateTime bitis = Convert.ToDateTime(oku["bit_tarih"].ToString().Trim());
                DateTime baslangic = Convert.ToDateTime(oku["bas_tarih"].ToString().Trim());
                if (bitis > dateTimePicker1.Value && baslangic < dateTimePicker2.Value)
                {
                    int sira = lvGecmis.Items.Count;
                    ResimListe.Images.Add(Image.FromFile(@oku["a_resim"].ToString().Trim()));
                    lvGecmis.SmallImageList = ResimListe;
                    lvGecmis.Items.Add(oku["a_id"].ToString().Trim(), sira);

                    lvGecmis.Items[sira].Tag = oku["k_id"].ToString().Trim();

                    lvGecmis.Items[sira].SubItems.Add(oku["m_adi"].ToString().Trim() + " " + oku["m_soyadi"].ToString().Trim());
                    lvGecmis.Items[sira].SubItems.Add(oku["bas_tarih"].ToString().Trim());
                    lvGecmis.Items[sira].SubItems.Add(oku["bit_tarih"].ToString().Trim());
                    lvGecmis.Items[sira].SubItems.Add(oku["p_adisoyadi"].ToString().Trim());
                    lvGecmis.Items[sira].SubItems.Add(oku["toplam_tutar"].ToString().Trim() + "₺");
                }
            }
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiraDetay kd = new KiraDetay();
            kd.id = lvGecmis.SelectedItems[0].Tag.ToString();
            kd.ShowDialog();
        }

        private void kiralamaİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string a = lvGecmis.SelectedItems[0].Tag.ToString();
                if (MessageBox.Show(" Kiralama işlemini iptal ederseniz tüm bilgileri kaybolacaktır geri getirilemez\nDevam etmek istiyor musunuz?", Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                    SqlCommand komut = new SqlCommand("delete from kiralama where k_id='" + a + "'", baglan);
                    baglan.Open();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Kiralama İşlemi iptal edildi.", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                gecmis_listele();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu\nHata:" + hata.Message, Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void detayGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiraDetay kd = new KiraDetay();
            kd.id = lvKiradakiler.SelectedItems[0].Tag.ToString();
            kd.ShowDialog();
        }

        private void kiralamaİptalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = lvKiradakiler.SelectedItems[0].Tag.ToString();
                if (MessageBox.Show(" Kiralama işlemini iptal ederseniz tüm bilgileri kaybolacaktır geri getirilemez\nDevam etmek istiyor musunuz?", Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                    SqlCommand komut = new SqlCommand("delete from kiralama where k_id='" + a + "'", baglan);
                    baglan.Open();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Kiralama İşlemi iptal edildi.", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                kirada_listele();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu\nHata:" + hata.Message, Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}
