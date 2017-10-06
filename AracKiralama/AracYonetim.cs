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
    public partial class AracYonetim : Form
    {
        public AracYonetim()
        {
            InitializeComponent();

        }
        Ayarlar ayarlar = new Ayarlar();
        private void sayfa2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = OFDresimbul.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                TBresimyol.Text = OFDresimbul.FileName;
                PBarabaresim.Image = Image.FromFile(TBresimyol.Text);
            }
        }

        private void BTN_kaydet_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = false;
            this.Cursor = Cursors.AppStarting;
            try
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



                SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                SqlCommand komut = new SqlCommand("INSERT INTO araba(a_marka,a_model,a_yili,a_fiyati,a_resim,a_plaka)VALUES('" + TB_marka.Text + "','" + TB_model.Text + "','" + NUD_yili.Value.ToString() + "','" + NUD_fiyat.Value.ToString() + "','Araba\\" + resim + "','" + tbPlaka.Text.ToUpper() + "') ", baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
                kayit_getir();
                MessageBox.Show("Araç kaydı yapıldı!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbPlaka.Text = TBresiminternet.Text = TBresimyol.Text = TB_marka.Text = TB_model.Text = "";
                PBarabaresim.Image= AracKiralama.Properties.Resources.no_photo;
            }
            catch (Exception ht)
            {

                MessageBox.Show("Bir Hata ile karşılaşıldı \nHata:"+ht.Message, Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tableLayoutPanel1.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void CBinternetten_CheckedChanged(object sender, EventArgs e)
        {
            label5.Enabled = TBresiminternet.Enabled = CBinternetten.Checked;
            PBarabaresim.Enabled = BTgozat.Enabled = TBresimyol.Enabled = !CBinternetten.Checked;
            
        }
        private void kayit_getir()
        {
            lvArabaList.Items.Clear();
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM araba", conn);
            SqlDataReader oku = komut.ExecuteReader();
            
            ImageList ResimListe = new ImageList();
            ResimListe.ImageSize = new Size(64, 64);
            
            while (oku.Read())
            {
                int sira = lvArabaList.Items.Count; 
                              
                
                ResimListe.Images.Add(Image.FromFile(@oku["a_resim"].ToString().Trim()));
                lvArabaList.SmallImageList = ResimListe;
                lvArabaList.Items.Add(oku["a_id"].ToString().Trim(), sira);

                lvArabaList.Items[sira].SubItems.Add(oku["a_marka"].ToString().Trim());
                   lvArabaList.Items[sira].SubItems.Add(oku["a_model"].ToString().Trim());
                   lvArabaList.Items[sira].SubItems.Add(oku["a_yili"].ToString().Trim());
                   lvArabaList.Items[sira].SubItems.Add( oku["a_fiyati"].ToString().Trim());
                lvArabaList.Items[sira].SubItems.Add(oku["a_plaka"].ToString().Trim());
            }
            conn.Close();
        }

        private void AracYonetim_Load(object sender, EventArgs e)
        {
            try
            {
                kayit_getir();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Araçlar Getirilemedi!\nHata:" + hata.Message, Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
         
            try
            {
                string a = lvArabaList.SelectedItems[0].Text;
                if (MessageBox.Show(" Seçili Araç silmek istediğize emin misiniz?", Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    SqlConnection baglan = new SqlConnection(ayarlar.baglanti);
                    SqlCommand komut = new SqlCommand("delete from araba where a_id='" + a+ "'", baglan);
                    baglan.Open();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Seçili kayıt başarıyla silindi", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                kayit_getir();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu\nHata:" + hata.Message, Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracGuncellecs ag = new AracGuncellecs();
            ag.id =lvArabaList.SelectedItems[0].Text; ;
            ag.ShowDialog();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayit_getir();
        }
        private void lvArabaList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                kayit_getir();
            }
        }
    }
}
