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
    public partial class Kiralama : Form
    {
        public Kiralama()
        {
            InitializeComponent();
        }
        Ayarlar ayarlar = new Ayarlar();
        public string p_id = Properties.Settings.Default.GirisYapan;
        private void Kiralama_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now.AddDays(1);
        }

        private void arabagetir()
        {
            lvArabaList.Items.Clear();
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            List<int> dolu = new List<int>();
            SqlCommand komut = new SqlCommand("SELECT * FROM kiralama", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                DateTime bitis = Convert.ToDateTime(oku["bit_tarih"].ToString().Trim());
                DateTime baslangic = Convert.ToDateTime(oku["bas_tarih"].ToString().Trim());
                if (bitis>dateTimePicker1.Value&&baslangic< dateTimePicker2.Value)
                {
                    dolu.Add(int.Parse(oku["araba_id"].ToString().Trim()));
                }
            }
            oku.Close();
            komut = new SqlCommand("SELECT * FROM araba", conn);
            oku = komut.ExecuteReader();

            ImageList ResimListe = new ImageList();
            ResimListe.ImageSize = new Size(40, 55);
            while (oku.Read())
            {
                bool kont = true;
                for (int i = 0; i < dolu.Count; i++)
                {
                    if (dolu[i] == int.Parse(oku["a_id"].ToString().Trim()))
                        kont = false;
                }
                if (kont)
                {
                    int sira = lvArabaList.Items.Count;
                    ResimListe.Images.Add(Image.FromFile(@oku["a_resim"].ToString().Trim()));
                    lvArabaList.SmallImageList = ResimListe;
                    lvArabaList.Items.Add(oku["a_id"].ToString().Trim(), sira);
                    lvArabaList.Items[sira].Tag = oku["a_fiyati"].ToString().Trim();


                    lvArabaList.Items[sira].SubItems.Add(oku["a_id"].ToString().Trim());
                    lvArabaList.Items[sira].SubItems.Add(oku["a_marka"].ToString().Trim());
                    lvArabaList.Items[sira].SubItems.Add(oku["a_model"].ToString().Trim());
                    lvArabaList.Items[sira].SubItems.Add(oku["a_yili"].ToString().Trim());
                    lvArabaList.Items[sira].SubItems.Add(oku["a_fiyati"].ToString().Trim()); 
                }
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int uzunluk = 600;
                SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                baglan.Open();
                SqlCommand komut = new SqlCommand("SELECT m_id,m_tcno,m_adi,m_soyadi,m_telefon FROM musteri Where m_soyadi like '%" + tbAra.Text + "%' OR m_adi like '%" + tbAra.Text + "%' OR m_tcno like '%" + tbAra.Text + "%' OR m_telefon like '%" + tbAra.Text + "%'", baglan);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMusteri.DataSource = dt;
                dgvMusteri.Columns[0].HeaderText = "Müsteri Kodu";
                dgvMusteri.Columns[1].HeaderText = "TC No";
                dgvMusteri.Columns[2].HeaderText = "Adı";
                dgvMusteri.Columns[3].HeaderText = "Soyadı";
                dgvMusteri.Columns[4].HeaderText = "Telefon";

                uzunluk = (dgvMusteri.Width - 30) / 5;
                dgvMusteri.Columns[0].Width = uzunluk;
                dgvMusteri.Columns[1].Width = uzunluk;
                dgvMusteri.Columns[2].Width = uzunluk;
                dgvMusteri.Columns[3].Width = uzunluk;
                dgvMusteri.Columns[4].Width = uzunluk;

                baglan.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message.ToString(), Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arabagetir();
        }

        private void lvArabaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeSpan fark = dateTimePicker2.Value - dateTimePicker1.Value;
                double kdvsiz = fark.Days * int.Parse(lvArabaList.SelectedItems[0].Tag.ToString());
                double indirim = (kdvsiz / 100) * int.Parse(nud_Indirim.Value.ToString());
                double kdv = (kdvsiz / 100) * 18;
                double kdvli = kdv + kdvsiz - indirim;

                lbHTutar.Text = kdvsiz.ToString();
                lbKDV.Text = kdv.ToString();
                lbTutar.Text = kdvli.ToString();
                lbIndirim.Text = indirim.ToString();
            }
            catch (Exception)
            {
                lbHTutar.Text = lbKDV.Text = lbTutar.Text = lbIndirim.Text = "00,00";
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvArabaList.SelectedItems.Count>0&&dgvMusteri.SelectedRows.Count>0)
                {
                    SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                    SqlCommand komut = new SqlCommand("INSERT INTO kiralama(araba_id,musteri_id,personel_id,bas_tarih,bit_tarih,toplam_tutar,indirim,kdv,h_tutar,kiralama_tarihi)VALUES('" + lvArabaList.SelectedItems[0].Text + "','" + dgvMusteri.CurrentRow.Cells[0].Value.ToString() + "','" + p_id + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "','" + float.Parse(lbTutar.Text) + "','" + float.Parse(lbIndirim.Text) + "','" + float.Parse(lbKDV.Text) + "','" + float.Parse(lbHTutar.Text) + "','" + DateTime.Now.ToShortDateString() + "') ", baglan);
                    baglan.Open();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    if (DialogResult.Yes==MessageBox.Show("Kiralama İşlemi Başarılı! \nFatura Yazdırmak İstemisiniz?", Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                    {
                        string id = "";
                        komut = new SqlCommand("SELECT * FROM kiralama where musteri_id='" + dgvMusteri.CurrentRow.Cells[0].Value.ToString()+ "' AND kiralama_tarihi='" + DateTime.Now.ToShortDateString() + "'", baglan);
                        baglan.Open();
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            id=dr["k_id"].ToString();
                        }
                        baglan.Close();
                        Rapor kd = new Rapor();
                        kd.k_id = id;
                        kd.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Kiralama İşlemi Başarısız!\n Araç ve kullanıcı seçildiğinden emin olunuz.", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kiralama İşlemi Başarısız!\nHata:"+hata.Message, Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            arabagetir();
        }

        private void nud_Indirim_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TimeSpan fark = dateTimePicker2.Value - dateTimePicker1.Value;
                double kdvsiz = fark.Days * int.Parse(lvArabaList.SelectedItems[0].Tag.ToString());
                double indirim = (kdvsiz / 100) * int.Parse(nud_Indirim.Value.ToString());
                double kdv = (kdvsiz / 100) * 18;
                double kdvli = kdv + kdvsiz - indirim;

                lbHTutar.Text = kdvsiz.ToString();
                lbKDV.Text = kdv.ToString();
                lbTutar.Text = kdvli.ToString();
                lbIndirim.Text = indirim.ToString();
            }
            catch (Exception)
            {
                lbHTutar.Text =  lbKDV.Text = lbTutar.Text = lbIndirim.Text = "00,00";
            }
        }
    }
}
