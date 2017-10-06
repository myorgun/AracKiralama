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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }
        public string m_id = "";
        Ayarlar ayarlar = new Ayarlar();
        private void button1_Click(object sender, EventArgs e)
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
                SqlCommand komut = new SqlCommand("update musteri set m_tcno='" + TB_tcno.Text + "',m_eposta='" + TB_eposta.Text + "',m_telefon='" + TB_telefon.Text + "',m_adres='" + TB_adres.Text + "',m_ehliyeti='" + TB_ehliyet.Text + "',m_adi='" + TB_isim.Text + "',m_soyadi='" + TB_soyad.Text + "',m_dogum_tarihi='" + DTP_dtar.Text + "',m_cinsiyet='" + CB_cins.Text + "',m_ehliyet_yili='" + NUD_eyil.Value.ToString() + "',m_ehliyet_puan='" + NUD_epuan.Value.ToString() + "' where m_id='" + m_id + "'", baglan);
                baglan.Open();
                komut.ExecuteNonQuery();

                KullaniciAyar ka = new KullaniciAyar();
                ka.kayit_getir();
                baglan.Close();
                MessageBox.Show("Müşteri Kaydı Güncellendi", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM musteri where m_id='"+m_id+"'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                TB_mustno.Text = oku["m_id"].ToString().Trim();
                TB_tcno.Text = oku["m_tcno"].ToString().Trim();
                TB_eposta.Text = oku["m_eposta"].ToString().Trim();
                TB_telefon.Text = oku["m_telefon"].ToString().Trim();
                TB_adres.Text = oku["m_adres"].ToString().Trim();
                TB_ehliyet.Text = oku["m_ehliyeti"].ToString().Trim();
                TB_isim.Text = oku["m_adi"].ToString().Trim();
                TB_soyad.Text = oku["m_soyadi"].ToString().Trim();
                DTP_dtar.Text = oku["m_dogum_tarihi"].ToString().Trim();
                CB_cins.Text =  oku["m_cinsiyet"].ToString().Trim();
                NUD_eyil.Value = int.Parse(oku["m_ehliyet_yili"].ToString().Trim());
                NUD_epuan.Value = int.Parse(oku["m_ehliyet_puan"].ToString().Trim());

            }
            oku.Close();
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DTP_dtar_ValueChanged(object sender, EventArgs e)
        {
            NUD_eyil.Minimum = DTP_dtar.Value.AddYears(18).Year;
            NUD_eyil.Maximum = DateTime.Now.Year;
        }
    }
}
