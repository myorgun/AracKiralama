using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class AracGuncellecs : Form
    {
        public AracGuncellecs()
        {
            InitializeComponent();
        }
        public string id = "";
        Ayarlar ayarlar = new Ayarlar();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AracGuncellecs_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM araba where a_id='" + id + "'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                tbID.Text= oku["a_id"].ToString().Trim();
                TB_marka.Text = oku["a_marka"].ToString().Trim();
                TB_model.Text = oku["a_model"].ToString().Trim();
                NUD_yili.Text = oku["a_yili"].ToString().Trim();
                NUD_fiyat.Text = oku["a_fiyati"].ToString().Trim();
                tbPlaka.Text = oku["a_plaka"].ToString().Trim();
                PBarabaresim.Image = Image.FromFile(@oku["a_resim"].ToString().Trim());

            }
            oku.Close();
            baglan.Close();
        }

        private void CBinternetten_CheckedChanged(object sender, EventArgs e)
        {
            label5.Enabled = TBresiminternet.Enabled = CBinternetten.Checked;
            PBarabaresim.Enabled = BTgozat.Enabled = TBresimyol.Enabled = !CBinternetten.Checked;
        }

        private void BTN_guncelle_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = false;
            this.Cursor = Cursors.AppStarting;
            try
            {
                SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                SqlCommand komut = new SqlCommand("UPDATE araba SET a_marka='" + TB_marka.Text + "',a_model='" + TB_model.Text + "',a_yili='" + NUD_yili.Value.ToString() + "',a_fiyati='" + NUD_fiyat.Value.ToString() + "',a_plaka='" + tbPlaka.Text.ToUpper() + "' where a_id='"+id+"' ", baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
                baglan.Close();
                if (TBresiminternet.Text != "" || TBresimyol.Text != "Dosya Seçilmedi")
                {
                    string resim = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".rsm";
                    if (CBinternetten.Checked)
                    {
                        WebClient client = new WebClient();
                        Stream stream = client.OpenRead(TBresiminternet.Text);
                        Bitmap bitmap = new Bitmap(stream);
                        stream.Flush();
                        stream.Close();
                        if (bitmap != null)
                        {
                            bitmap.Save(@"Araba\" + resim, ImageFormat.Jpeg);
                        }
                    }
                    else
                    {
                        string item = OFDresimbul.FileName;
                        string[] dosyaadkirp = item.Split('\\');
                        string[] uzantkirp = dosyaadkirp[dosyaadkirp.Length - 1].Split('.');
                        string uzanti = uzantkirp[uzantkirp.Length - 1].ToString();
                        resim = resim + "." + uzanti;
                        File.Copy(item, @"Araba\" + resim);
                    }

                    komut = new SqlCommand("UPDATE araba set a_resim='Araba\\" + resim + "' where a_id='" + id + "' ", baglan);
                    baglan.Open();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
                MessageBox.Show("Araç Güncellendi", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ht)
            {

                MessageBox.Show("Bir Hata ile karşılaşıldı \nHata:" + ht.Message, Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tableLayoutPanel1.Enabled = true;
            this.Cursor = Cursors.Default;
        }
    }
}
