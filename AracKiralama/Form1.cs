using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ayarlar ayarlar = new Ayarlar();
        Control[] butonDizi = new Control[50];
        int menu = 0;
        public string k_id = Properties.Settings.Default.GirisYapan;
        public string adsoyad;
        private Point mousedurumu;
        private bool basildi = false;

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void BTN_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.ProgAdi;
            notifyIcon1.Icon = Properties.Resources.ikon1;
            notifyIcon1.Text = Properties.Settings.Default.ProgAdi;

            label2.Text = Properties.Settings.Default.Marka.ToString().Trim();
            LB_adsoyad_pn.Text = adsoyad;
            SqlConnection conn = new SqlConnection(ayarlar.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT menu.* FROM menu inner join izinler on menu.menu_id=izinler.menu_id where izinler.p_id='"+k_id+ "' order by menu.siralama desc  ", conn);
            SqlDataReader oku = komut.ExecuteReader();
            
            for (int i = 0; oku.Read(); i++)
            {
                
                Button btn = new Button();
                btn.Dock = DockStyle.Top;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor =  Color.FromArgb(89, 171, 227);
                btn.Name = "menu_" + i.ToString();
                btn.TextAlign=ContentAlignment.MiddleRight;
                btn.Tag = oku["menu_id"].ToString().TrimEnd();
                btn.Text = oku["menu_metin"].ToString().TrimEnd();
                btn.Click += new EventHandler(dinamikMetod);
                butonDizi[i] = btn;
                p_sol.Controls.Add(btn);
                menu=i;
            }
            oku.Close();
            conn.Close();
           
        }

        private void dinamikMetod(object sender, EventArgs e)
        {
            for (int a = 0; a <= menu; a++)
                butonDizi[a].BackColor= Color.FromArgb(89, 171, 227);

            Button dinamikButon = (sender as Button);
            dinamikButon.BackColor=Color.FromArgb(231, 231, 222);
            string sayfa = dinamikButon.Tag.ToString();
            PNana.Controls.Clear();
            if (sayfa=="2")
            {
                KullaniciAyar ka = new KullaniciAyar();
                ka.TopLevel = false;
                PNana.Controls.Add(ka);
                ka.Show();
                ka.Dock = DockStyle.Fill;
                ka.BringToFront();
            }
            else if (sayfa=="1")
            {
                MusteriAyar mayar = new MusteriAyar();
                mayar.TopLevel = false;
                PNana.Controls.Add(mayar);
                mayar.Show();
                mayar.Dock = DockStyle.Fill;
                mayar.BringToFront();
            }
            else if (sayfa == "3")
            {
                AracYonetim ayon = new AracYonetim();
                ayon.TopLevel = false;
                PNana.Controls.Add(ayon);
                ayon.Show();
                ayon.Dock = DockStyle.Fill;
                ayon.BringToFront();
            }
            else if (sayfa == "4")
            {
                Kiralama kira = new Kiralama();
                kira.TopLevel = false;
                PNana.Controls.Add(kira);
                kira.Show();
                kira.Dock = DockStyle.Fill;
                kira.BringToFront();
            }
            else if (sayfa == "5")
            {
                Raporlar r = new Raporlar();
                r.TopLevel = false;
                PNana.Controls.Add(r);
                r.Show();
                r.Dock = DockStyle.Fill;
                r.BringToFront();
            }
            else if (sayfa == "7")
            {
                SigortaYonetim sy = new SigortaYonetim();
                sy.TopLevel = false;
                PNana.Controls.Add(sy);
                sy.Show();
                sy.Dock = DockStyle.Fill;
                sy.BringToFront();
            }
            else if (sayfa == "8")
            {

            }
            else if (sayfa == "9")
            {
                Kiralamalar kira = new Kiralamalar();
                kira.TopLevel = false;
                PNana.Controls.Add(kira);
                kira.Show();
                kira.Dock = DockStyle.Fill;
                kira.BringToFront();
            }
            else if (sayfa == "10")
            {
                ProgramAyar pa = new ProgramAyar();
                pa.TopLevel = false;
                PNana.Controls.Add(pa);
                pa.Show();
                pa.Dock = DockStyle.Fill;
                pa.BringToFront();
            }


        }
        bool sorma = true;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sorma)
            if (DialogResult.Yes == MessageBox.Show("Programı kapatmak üzeresini.Kaydetmediğiniz işlemler kaybolacaktır.\nDevam edilsin mi?", Properties.Settings.Default.ProgAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                sorma = false;
                Application.Exit();
            }
            else
            {
                
                e.Cancel = true;
            }
                

        }
        private void LL_cikis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hakkimizda hak = new Hakkimizda();
            hak.ShowDialog();
        }

        private void T_zaman_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Second%2==0)
            {
                BTN_zaman.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            }
            else
            {
                BTN_zaman.Text = DateTime.Now.Hour.ToString() + " " + DateTime.Now.Minute.ToString();
            }
            BTN_zaman.Text = BTN_zaman.Text +"\n"+ DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString()+ "/" + DateTime.Now.Year.ToString();
        }

        private void tblust_MouseDown(object sender, MouseEventArgs e)
        {
            int xdurum;
            int ydurum;
            if
            (e.Button == MouseButtons.Left)
            {
                xdurum = -e.X - SystemInformation.FrameBorderSize.Width;
                ydurum = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                mousedurumu = new Point(xdurum, ydurum);
                basildi = true;
            }
        }

        private void tblust_MouseMove(object sender, MouseEventArgs e)
        {
            if (basildi)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mousedurumu.X, mousedurumu.Y);
                Location = mousePos;
            }
        }

        private void tblust_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                basildi = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void LL_hesap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonelGuncelle pergun = new PersonelGuncelle();
            pergun.p_id = Properties.Settings.Default.GirisYapan;
            pergun.Text = "Hesap Ayarları";
            pergun.PN_chkbox.Visible = false;
            pergun.ShowDialog();
        }
    }
}
