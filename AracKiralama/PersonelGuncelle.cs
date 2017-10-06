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
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }
        public string p_id = "";
        CheckBox[] menudizi = new CheckBox[50];
        int menu = 0;
        Ayarlar ayarlar = new Ayarlar();
        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM menu order by siralama desc", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            for (int i = 0; oku.Read(); i++)
            {
                CheckBox btn = new CheckBox();
                btn.Dock = DockStyle.Top;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Name = "menu_" + i.ToString();
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Tag = oku["menu_id"].ToString().TrimEnd();
                btn.Text = oku["menu_metin"].ToString().Trim();
                menudizi[i] = btn;
                menu = i;
                PN_chkbox.Controls.Add(btn);
            }
            oku.Close();

            komut = new SqlCommand("SELECT * FROM personel where p_id='"+p_id+"'", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                TB_isimsoyisim.Text = oku["p_adisoyadi"].ToString().Trim();
                TB_kullaniciadi.Text = oku["p_kullaniciadi"].ToString().Trim();
                TB_eposta.Text = oku["p_eposta"].ToString().Trim();
                TB_telefon.Text = oku["p_telefon"].ToString().Trim();
                TB_sifre.Text = oku["p_sifre"].ToString().Trim();
            }
            oku.Close();

            komut = new SqlCommand("SELECT * FROM izinler where p_id='" + p_id + "'", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                for (int i = 0; i <= menu; i++)
                {
                    if (menudizi[i].Tag.ToString() == oku["menu_id"].ToString().Trim())
                        menudizi[i].Checked = true;
                }
            }
            oku.Close();
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_guncelle_Click(object sender, EventArgs e)
        {
            if (TB_kullaniciadi.Text.Trim() == "")
                EP_hata.SetError(TB_kullaniciadi, "Boş Bırakılamaz");

            else if (TB_eposta.Text.Trim() == "")
                EP_hata.SetError(TB_eposta, "Boş Bırakılamaz");

            else if (TB_isimsoyisim.Text.Trim() == "")
                EP_hata.SetError(TB_isimsoyisim, "Boş Bırakılamaz");

            else if (TB_sifre.Text.Trim() == "")
                EP_hata.SetError(TB_sifre, "Boş Bırakılamaz");

            else if (TB_telefon.Text.Trim() == "")
                EP_hata.SetError(TB_telefon, "Boş Bırakılamaz");
            else
            {
                List<string> m_id = new List<string>();
                for (int i = 0; i <= menu; i++)
                {
                    if (menudizi[i].Checked == true)
                    {
                        m_id.Add(menudizi[i].Tag.ToString());
                    }

                }
                if (m_id.Count > 0)
                {
                    SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                    SqlCommand komut = new SqlCommand("update personel set p_adisoyadi='"+TB_isimsoyisim.Text+"',p_telefon='"+TB_telefon.Text+"',p_eposta='"+TB_eposta.Text+"',p_kullaniciadi='"+TB_kullaniciadi.Text+"',p_sifre='"+TB_sifre.Text+"' where p_id='"+p_id+"'", baglan);
                    baglan.Open();
                    komut.ExecuteNonQuery();
              
                    komut = new SqlCommand("delete from izinler where p_id='" + p_id + "'", baglan);
                    komut.ExecuteNonQuery();

                    for (int j = 0; j < m_id.Count; j++)
                    {
                        komut = new SqlCommand("INSERT INTO izinler(menu_id,p_id)VALUES('" + m_id[j].ToString() + "','" + p_id + "') ", baglan);
                        komut.ExecuteNonQuery();
                    }
                    KullaniciAyar ka = new KullaniciAyar();
                    ka.kayit_getir();



                    baglan.Close();
                    MessageBox.Show("Personel Kaydı Güncellendi", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("En az bir tane menü seçmelisiniz!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked)
                TB_sifre.PasswordChar = TB_telefon.PasswordChar;
            else
                TB_sifre.PasswordChar = '☺';
        }
    }
}
