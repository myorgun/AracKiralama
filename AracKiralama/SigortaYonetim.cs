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
    public partial class SigortaYonetim : Form
    {
        public SigortaYonetim()
        {
            InitializeComponent();
        }
        Ayarlar ayarlar = new Ayarlar();
        List<int> varolan = new List<int>();
        private void SigortaYonetim_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            dateTimePicker2.Value= DateTime.Now.AddYears(1);
            kayit_getir();
            arabagetir();
        }
        
        private void arabagetir()
        {
            try
            {
                dgvAraba.Rows.Clear();
                int uzunluk = 600;

                SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                baglan.Open();
                SqlCommand komut = new SqlCommand("SELECT a_id,a_marka,a_model,a_yili,a_plaka FROM araba ", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    bool kont = true;
                    for (int i = 0; i < varolan.Count; i++)
                    {
                        if (varolan[i] == int.Parse(oku["a_id"].ToString().Trim()))
                            kont = false;
                    }
                    if (kont)
                    {
                        dgvAraba.Rows.Add(oku["a_id"].ToString().Trim(),oku["a_marka"].ToString().Trim(),oku["a_model"].ToString().Trim(),oku["a_yili"].ToString().Trim(),oku["a_plaka"].ToString().Trim());
                    }
                }
                baglan.Close();
                dgvAraba.Columns[0].HeaderText = "Araba";
                dgvAraba.Columns[1].HeaderText = "Marka";
                dgvAraba.Columns[2].HeaderText = "Model";
                dgvAraba.Columns[3].HeaderText = "Yılı";
                dgvAraba.Columns[4].HeaderText = "Plaka";

                uzunluk = (dgvAraba.Width - 21) / 5;
                dgvAraba.Columns[0].Width = uzunluk;
                dgvAraba.Columns[1].Width = uzunluk;
                dgvAraba.Columns[2].Width = uzunluk;
                dgvAraba.Columns[3].Width = uzunluk;
                dgvAraba.Columns[4].Width = uzunluk;
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message.ToString(), Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kayit_getir()
        {
            lvSigorta.Items.Clear();
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT araba.*,sigorta.* FROM araba inner join sigorta on araba.a_id=sigorta.a_id", conn);
            SqlDataReader oku = komut.ExecuteReader();

            ImageList ResimListe = new ImageList();
            ResimListe.ImageSize = new Size(64, 64);

            while (oku.Read())
            {
                int sira = lvSigorta.Items.Count;

                varolan.Add(int.Parse((oku["a_id"].ToString().Trim())));
                ResimListe.Images.Add(Image.FromFile(@oku["a_resim"].ToString().Trim()));
                lvSigorta.SmallImageList = ResimListe;
                lvSigorta.Items.Add(oku["a_id"].ToString().Trim(), sira);

                lvSigorta.Items[sira].SubItems.Add(oku["a_marka"].ToString().Trim());
                lvSigorta.Items[sira].SubItems.Add(oku["sigorta_baslama"].ToString().Trim());
                lvSigorta.Items[sira].SubItems.Add(oku["sigorta_bitis"].ToString().Trim());
                lvSigorta.Items[sira].SubItems.Add(oku["sigorta_bedeli"].ToString().Trim());
            }
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddYears(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a_id = dgvAraba.CurrentRow.Cells[0].Value.ToString();
            if (dateTimePicker1.Text.Trim() == "")
                EP_hata.SetError(dateTimePicker1, "Boş Bırakılamaz");
            else if (dateTimePicker2.Text.Trim() == "")
                EP_hata.SetError(dateTimePicker2, "Boş Bırakılamaz");
            else if (tbTutar.Text.Trim() == "")
                EP_hata.SetError(tbTutar, "Boş Bırakılamaz");
            else if (a_id == "")
                MessageBox.Show("Bir Araç Seçmelisiniz", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                SqlCommand komut = new SqlCommand("INSERT INTO sigorta(a_id,sigorta_baslama,sigorta_bitis,sigorta_bedeli)VALUES('" + a_id + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "','" + tbTutar.Text + "') ", baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Araç Sigortası Girildi!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                kayit_getir();
                arabagetir();
            }
        }
    }
}
