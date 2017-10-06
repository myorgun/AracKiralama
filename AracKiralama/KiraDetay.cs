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
    public partial class KiraDetay : Form
    {
        public KiraDetay()
        {
            InitializeComponent();
        }
        public string id = "";
        Ayarlar ayarlar = new Ayarlar();
        private void KiraDetay_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kiralama inner join araba on kiralama.araba_id = araba.a_id inner join musteri on kiralama.musteri_id = musteri.m_id inner join personel on kiralama.personel_id = personel.p_id where k_id='"+id+"'", conn);
            SqlDataReader oku = komut.ExecuteReader();

            ImageList ResimListe = new ImageList();
            ResimListe.ImageSize = new Size(64, 64);

            while (oku.Read())
            {
                pictureBox1.Image= Image.FromFile(@oku["a_resim"].ToString().Trim());
                label17.Text = oku["a_marka"].ToString().Trim();
                label18.Text = oku["a_model"].ToString().Trim();
                label19.Text = oku["a_plaka"].ToString().Trim();
                label20.Text = oku["a_yili"].ToString().Trim();

                label21.Text = oku["m_adi"].ToString().Trim() + " " + oku["m_soyadi"].ToString().Trim();
                label22.Text = oku["m_telefon"].ToString().Trim();
                label23.Text = oku["m_tcno"].ToString().Trim();

                label24.Text = oku["k_id"].ToString().Trim();

                label25.Text = oku["p_adisoyadi"].ToString().Trim();

                label26.Text = oku["bas_tarih"].ToString().Trim();
                label27.Text = oku["bit_tarih"].ToString().Trim();
                label28.Text = oku["kiralama_tarihi"].ToString().Trim();

                lbHTutar.Text = oku["h_tutar"].ToString().Trim();
                lbIndirim.Text = oku["indirim"].ToString().Trim();
                lbKDV.Text = oku["kdv"].ToString().Trim();
                lbTutar.Text = oku["toplam_tutar"].ToString().Trim();

            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rapor r = new Rapor();
            r.k_id = label24.Text;
            r.ShowDialog();
        }
    }
}
