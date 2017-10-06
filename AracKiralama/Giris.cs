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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        Ayarlar ayarlar = new Ayarlar();
        
        
        private void Giris_Load(object sender, EventArgs e)
        {
         //  Properties.Settings.Default.Kurulum = false;            Properties.Settings.Default.Save();

            pictureBox2.Image = Properties.Resources._208;
            label4.Text = Properties.Settings.Default.ProgAdi;
            this.Text = "Giriş - " + Properties.Settings.Default.ProgAdi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false;
                panel2.Visible = true;

                string adsoyad = "";
                string id = "";
                SqlConnection conn = new SqlConnection(ayarlar.baglanti);
                SqlCommand komut = new SqlCommand("SELECT * FROM personel where p_kullaniciadi='" + textBox1.Text + "' AND p_sifre='" + textBox2.Text + "'", conn);
                conn.Open();
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Properties.Settings.Default.GirisYapan = dr["p_id"].ToString();
                    id = dr["p_id"].ToString();
                    adsoyad = dr["p_adisoyadi"].ToString().TrimEnd();
                }

                if (id != "")
                {
                    Form1 giris = new Form1();
                    giris.adsoyad = adsoyad;
                    giris.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    panel1.Visible = true;
                    panel2.Visible = false;
                }
                conn.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Giriş Başarısız \nHata:"+hata.Message, Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void BTN_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
