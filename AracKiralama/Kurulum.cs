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
    public partial class Kurulum : Form
    {
        public Kurulum()
        {
            InitializeComponent();
        }

        private void Kurulum_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.kurulum;

        //    Properties.Settings.Default.Kurulum = true;            Properties.Settings.Default.Save();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = rbYerel.Checked;
            groupBox2.Enabled = rbSunucu.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string baglanti = "";
            if (rbYerel.Checked)
            {
                baglanti = @"Data Source=" + textBox1.Text + ";Initial Catalog=" + textBox2.Text + ";Integrated Security=True";

            }
            else
            {
                baglanti = @"Data Source =" + textBox4.Text + "; Initial Catalog = " + textBox3.Text + "; User ID = " + textBox5.Text + "; Password = " + textBox6.Text + "; Integrated Security = false";
            }


            try
            {
                List<string> gelentablo = new List<string>();
                string[] tablolar = new string[] { "araba", "izinler", "kiralama", "menu", "musteri", "personel", "sigorta" };
                List<string> olmayanlar = new List<string>();
                string olmayan = "";
                SqlConnection conn = new SqlConnection(baglanti);
                SqlCommand komut = new SqlCommand("select * from sys.tables", conn);
                conn.Open();
                SqlDataReader dr = komut.ExecuteReader();
                for (int i = 0; dr.Read(); i++)
                {
                    gelentablo.Add(dr["name"].ToString());
                }
                conn.Close();
                for (int j = 0; j < tablolar.Length; j++)
                {
                    int a = gelentablo.IndexOf(tablolar[j]);
                    if (a == -1)
                    {
                        olmayanlar.Add(tablolar[j]);
                        olmayan = olmayan + "\n-" + tablolar[j];
                    }
                }
                if (olmayanlar.Count > 0)
                {
                    MessageBox.Show("Veritabanı Bağlantısı Başarılı\nEksik Tablolar Var\n" + olmayan, Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Veritabanı Bağlantısı Başarılı!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != 2)
                tabControl1.SelectedIndex += 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdim3Atla.Checked)
                if (DialogResult.No == MessageBox.Show("Eğer veritabanında başka kullanıcı yoksa giriş yapmanız mümkün olmayacaktır\nDevam etmek istiyor musunuz?", Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    cbAdim3Atla.Checked = false;
            TB_eposta.Enabled = TB_isimsoyisim.Enabled = TB_kullaniciadi.Enabled = TB_sifre.Enabled = TB_telefon.Enabled = !cbAdim3Atla.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex!=0)
                tabControl1.SelectedIndex -= 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                listBox1.Items.Add("Kurulum Ayarları Kaydediliyor \t" + DateTime.Now.ToString());
                //Veritabanı Kaydı
                veritabani();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Kurulum Başarısız! "+ex.Message+"\t" + DateTime.Now.ToString());
            }
            this.Cursor = Cursors.Default;
        }

        private void veritabani()
        {
            listBox1.Items.Add("Veritabanı Bilgileri Kaydediliyor \t" + DateTime.Now.ToString());
            string baglanti = "";
            if (rbYerel.Checked)
            {
                baglanti = @"Data Source=" + textBox1.Text + ";Initial Catalog=" + textBox2.Text + ";Integrated Security=True";

            }
            else
            {
                baglanti = @"Data Source =" + textBox4.Text + "; Initial Catalog = " + textBox3.Text + "; User ID = " + textBox5.Text + "; Password = " + textBox6.Text + "; Integrated Security = false";
            }


            try
            {
                List<string> gelentablo = new List<string>();
                string[] tablolar = new string[] { "araba", "izinler", "kiralama", "menu", "musteri", "personel", "sigorta" };
                List<string> olmayanlar = new List<string>();
                string olmayan = "";
                SqlConnection conn = new SqlConnection(baglanti);
                SqlCommand komut = new SqlCommand("select * from sys.tables", conn);
                conn.Open();
                SqlDataReader dr = komut.ExecuteReader();
                for (int i = 0; dr.Read(); i++)
                {
                    gelentablo.Add(dr["name"].ToString());
                }
                conn.Close();
                for (int j = 0; j < tablolar.Length; j++)
                {
                    int a = gelentablo.IndexOf(tablolar[j]);
                    if (a == -1)
                    {
                        olmayanlar.Add(tablolar[j]);
                        olmayan = olmayan + "\n-" + tablolar[j];
                    }
                }
                if (olmayanlar.Count > 0)
                {
                    listBox1.Items.Add("Veritabanı Bağlantısı Başarılı. Eksik Tablolar Var! \t" + DateTime.Now.ToString());
                    listBox1.Items.Add("Kurulum Başarısız! \t" + DateTime.Now.ToString());
                }
                else
                {
                    listBox1.Items.Add("Veritabanı Bağlantısı Başarılı! \t" + DateTime.Now.ToString());
                    if (rbYerel.Checked)
                    {
                        Properties.Settings.Default.Baglanti = baglanti;
                        Properties.Settings.Default.sunucu = textBox1.Text;
                        Properties.Settings.Default.yvt = textBox2.Text;
                        Properties.Settings.Default.ip = "";
                        Properties.Settings.Default.svt = "";
                        Properties.Settings.Default.kullanici = "";
                        Properties.Settings.Default.sifre = "";
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.Baglanti = baglanti;
                        Properties.Settings.Default.sunucu = "";
                        Properties.Settings.Default.yvt = "";
                        Properties.Settings.Default.ip = textBox4.Text;
                        Properties.Settings.Default.svt = textBox3.Text;
                        Properties.Settings.Default.kullanici = textBox5.Text;
                        Properties.Settings.Default.sifre = textBox6.Text;
                        Properties.Settings.Default.Save();
                    }
                    listBox1.Items.Add("Veritabanı Bilgileri Kaydedildi! \t" + DateTime.Now.ToString());
                    Personel();
                }

            }
            catch
            {
                listBox1.Items.Add("Veritabanı Bağlantısı Başarısız! \t" + DateTime.Now.ToString());
                listBox1.Items.Add("Kurulum Başarısız! \t" + DateTime.Now.ToString());
            }
        }

        private void Personel()
        {
            
            //Personel Kaydı
            if (!cbAdim3Atla.Checked)
            {
                listBox1.Items.Add("Personel Bilgileri Kaydediliyor \t" + DateTime.Now.ToString());
                if ((TB_kullaniciadi.Text != "" || TB_sifre.Text != "" || TB_isimsoyisim.Text != "" || TB_eposta.Text != ""))
                {
                    SqlConnection baglan = new SqlConnection(Properties.Settings.Default.Baglanti);
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

                    for (int j = 1; j <= 10; j++)
                    {
                        komut = new SqlCommand("INSERT INTO izinler(menu_id,p_id)VALUES('" + j + "','" + id + "') ", baglan);
                        komut.ExecuteNonQuery();
                    }
                    baglan.Close();
                    listBox1.Items.Add("Yeni personel kaydedildi \t" + DateTime.Now.ToString());
                    Properties.Settings.Default.Kurulum = true;
                    Properties.Settings.Default.Save();
                    listBox1.Items.Add("Kurulum Ayarları Başarılı \t" + DateTime.Now.ToString());
                    this.Hide();
                    Giris giris = new Giris();
                    giris.Show();
                }
                else
                {
                    listBox1.Items.Add("Adım 3'te boş bilgiler var \t" + DateTime.Now.ToString());
                    listBox1.Items.Add("Kurulum Başarısız! \t" + DateTime.Now.ToString());
                }
            }
            else
            {
                Properties.Settings.Default.Kurulum = true;
                Properties.Settings.Default.Save();
                listBox1.Items.Add("Kurulum Ayarları Başarılı \t" + DateTime.Now.ToString());
                this.Hide();
                Giris giris = new Giris();
                giris.Show();
            }
        }
    }
}
