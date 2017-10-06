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
    public partial class KullaniciAyar : Form
    {
        public KullaniciAyar()
        {
            InitializeComponent();
        }
        CheckBox[] menudizi = new CheckBox[50];
        CheckBox[] menudizi2 = new CheckBox[50];
        int menu = 0;
        Ayarlar ayarlar = new Ayarlar();
        private void KullaniciAyar_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            try
            {
                kayit_getir();
            }
            catch (Exception)
            {

            }
        }

        public void kayit_getir()
        {
            listView1.Items.Clear();
            PN_chkbox.Controls.Clear();
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM menu order by siralama desc", conn);
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

            komut = new SqlCommand("SELECT * FROM personel", conn);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {

                if (oku["p_id"].ToString().Trim()!=Properties.Settings.Default.GirisYapan)
                {
                    int sira = listView1.Items.Count;
                    listView1.Items.Add(oku["p_id"].ToString().Trim());
                    listView1.Items[sira].SubItems.Add(oku["p_adisoyadi"].ToString().Trim());
                    listView1.Items[sira].SubItems.Add(oku["p_kullaniciadi"].ToString().Trim());
                    listView1.Items[sira].SubItems.Add(oku["p_eposta"].ToString().Trim());
                    listView1.Items[sira].SubItems.Add(oku["p_telefon"].ToString().Trim()); 
                }
            }
            conn.Close();
        }

        private void BTN_kaydet_Click(object sender, EventArgs e)
        {
            if (TB_kullaniciadi.Text.Trim() == "")
                EP_hata.SetError(TB_kullaniciadi, "Boş Bırakılamaz");

            else if (TB_eposta.Text.Trim() == "")
                EP_hata.SetError(TB_eposta, "Boş Bırakılamaz");

            else if(TB_isimsoyisim.Text.Trim() == "")
                EP_hata.SetError(TB_isimsoyisim, "Boş Bırakılamaz");

            else if(TB_sifre.Text.Trim() == "")
                EP_hata.SetError(TB_sifre, "Boş Bırakılamaz");

            else if(TB_telefon.Text.Trim() == "")
                EP_hata.SetError(TB_telefon, "Boş Bırakılamaz");
            else
            {
                List<string> m_id = new List<string>();
                for (int i = 0; i <= menu; i++)
                {
                    if (menudizi[i].Checked==true)
                    {
                        m_id.Add(menudizi[i].Tag.ToString());
                    }

                }
                if (m_id.Count>0)
                {
                    SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                    SqlCommand komut = new SqlCommand("INSERT INTO personel(p_adisoyadi,p_telefon,p_eposta,p_kullaniciadi,p_sifre)VALUES('" + TB_kullaniciadi.Text + "','" + TB_telefon.Text + "','" + TB_eposta.Text + "','" + TB_kullaniciadi.Text + "','" + TB_sifre.Text + "') ", baglan);
                    baglan.Open();
                    komut.ExecuteNonQuery();

                    int id = 0;
                    komut = new SqlCommand("SELECT p_id FROM personel where p_kullaniciadi='" + TB_kullaniciadi.Text + "' and p_sifre='" + TB_sifre.Text + "'", baglan);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        id = Convert.ToInt32(oku["p_id"].ToString());
                    }
                    oku.Close();

                    for (int j = 0; j < m_id.Count; j++)
                    {
                        komut = new SqlCommand("INSERT INTO izinler(menu_id,p_id)VALUES('" + m_id[j].ToString() + "','" + id + "') ", baglan);
                        komut.ExecuteNonQuery();
                    }
                    baglan.Close();
                    MessageBox.Show("Personel Kaydı Yapıldı!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    kayit_getir();
                }
                else
                    MessageBox.Show("En az bir tane menü seçmelisiniz!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK,MessageBoxIcon.Error);


            }


        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {
                PersonelGuncelle pergun = new PersonelGuncelle();
                pergun.p_id = listView1.SelectedItems[0].Text;
                pergun.ShowDialog();
            }
            catch { }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Seçili personeli silmek istediğize emin misiniz?", "Kayıt Yapılmadı", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                    SqlCommand komut = new SqlCommand("delete from personel where p_id='" + listView1.SelectedItems[0].Text + "'", baglan);
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
            try
            {
                kayit_getir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu \nHata:"+ex.Message, Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
