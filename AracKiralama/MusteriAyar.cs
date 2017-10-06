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
    public partial class MusteriAyar : Form
    {
        public MusteriAyar()
        {
            InitializeComponent();
        }
        Ayarlar ayarlar = new Ayarlar();
        private void MusteriAyar_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            kayit_getir();
            DTP_dtar.MaxDate = DateTime.Now.AddYears(-18);
            NUD_eyil.Minimum = NUD_eyil.Maximum = DateTime.Now.Year;
        }
        private void kayit_getir()
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            SqlCommand komut =new SqlCommand("SELECT * FROM musteri order by m_id asc", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                int sira = listView1.Items.Count;
                listView1.Items.Add(oku["m_id"].ToString().Trim());
                listView1.Items[sira].SubItems.Add(oku["m_tcno"].ToString().Trim());
                listView1.Items[sira].SubItems.Add(oku["m_adi"].ToString().Trim()+" "+ oku["m_soyadi"].ToString().Trim());
                listView1.Items[sira].SubItems.Add(oku["m_eposta"].ToString().Trim());
                listView1.Items[sira].SubItems.Add(oku["m_telefon"].ToString().Trim());
                listView1.Items[sira].SubItems.Add(oku["m_cinsiyet"].ToString().Trim());
            }
            conn.Close();
        }

        private void BTN_kaydet_Click(object sender, EventArgs e)
        {
            if (TB_tcno.Text.Trim() == "")
                EP_hata.SetError(TB_tcno, "Boş Bırakılamaz");
            else if (TB_isim.Text.Trim() == "")
                EP_hata.SetError(TB_isim, "Boş Bırakılamaz");
            else if (TB_soyad.Text.Trim() == "")
                EP_hata.SetError(TB_soyad, "Boş Bırakılamaz");
            else if (TB_telefon.Text.Trim() == "")
                EP_hata.SetError(TB_telefon, "Boş Bırakılamaz");
            else if (TB_eposta.Text.Trim() == "")
                EP_hata.SetError(TB_eposta, "Boş Bırakılamaz");
            else if (TB_adres.Text.Trim() == "")
                EP_hata.SetError(TB_adres, "Boş Bırakılamaz");
            else if (DTP_dtar.Text.Trim() == "")
                EP_hata.SetError(DTP_dtar, "Boş Bırakılamaz");
            else if (TB_ehliyet.Text.Trim() == "")
                EP_hata.SetError(TB_ehliyet, "Boş Bırakılamaz");
            else if (NUD_eyil.Text.Trim() == "")
                EP_hata.SetError(NUD_eyil, "Boş Bırakılamaz");
            else if (NUD_epuan.Text.Trim() == "")
                EP_hata.SetError(NUD_epuan, "Boş Bırakılamaz");

            else
            {
                SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                SqlCommand komut = new SqlCommand("INSERT INTO musteri(m_tcno,m_adi,m_soyadi,m_telefon,m_eposta,m_adres,m_dogum_tarihi,m_cinsiyet,m_ehliyeti,m_ehliyet_yili,m_ehliyet_puan)VALUES('" + TB_tcno.Text + "','" + TB_isim.Text + "','" + TB_soyad.Text + "','" + TB_telefon.Text + "','" + TB_eposta.Text + "','" + TB_adres.Text + "','" + DTP_dtar.Text + "','" + CB_cins.Text + "','" + TB_ehliyet.Text.ToUpper() + "','" + NUD_eyil.Text + "','" + NUD_epuan.Text + "') ", baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Müşteri Kaydı Yapıldı!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                kayit_getir();
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriGuncelle mgun = new MusteriGuncelle();
                mgun.m_id = listView1.SelectedItems[0].Text;
                mgun.ShowDialog();
            }
            catch { }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Seçili Müşteriyi silmek istediğize emin misiniz?", Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                    SqlCommand komut = new SqlCommand("delete from musteri where m_id='" + listView1.SelectedItems[0].Text + "'", baglan);
                    baglan.Open();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Seçili kayıt başarıyla silindi", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                kayit_getir();
            }
            catch (Exception)
            {
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayit_getir();
        }

        private void DTP_dtar_ValueChanged(object sender, EventArgs e)
        {
            NUD_eyil.Minimum = DTP_dtar.Value.AddYears(18).Year;
            NUD_eyil.Maximum = DateTime.Now.Year;
        }
    }
}
