namespace AracKiralama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p_ust = new System.Windows.Forms.Panel();
            this.tblust = new System.Windows.Forms.TableLayoutPanel();
            this.PN_kisisel = new System.Windows.Forms.Panel();
            this.LL_cikis = new System.Windows.Forms.LinkLabel();
            this.LL_hesap = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_adsoyad_pn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.p_ust_sag = new System.Windows.Forms.Panel();
            this.BTN_zaman = new System.Windows.Forms.Button();
            this.BTN_kapat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_boyut = new System.Windows.Forms.Button();
            this.BTN_kucult = new System.Windows.Forms.Button();
            this.p_sol = new System.Windows.Forms.Panel();
            this.T_zaman = new System.Windows.Forms.Timer(this.components);
            this.PNana = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl3 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl4 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.ttAciklama = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.p_ust.SuspendLayout();
            this.tblust.SuspendLayout();
            this.PN_kisisel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.p_ust_sag.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabControl3.SuspendLayout();
            this.metroTabControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_ust
            // 
            this.p_ust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.p_ust.Controls.Add(this.tblust);
            this.p_ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_ust.Location = new System.Drawing.Point(0, 0);
            this.p_ust.Name = "p_ust";
            this.p_ust.Size = new System.Drawing.Size(1146, 80);
            this.p_ust.TabIndex = 0;
            // 
            // tblust
            // 
            this.tblust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tblust.ColumnCount = 3;
            this.tblust.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblust.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblust.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblust.Controls.Add(this.PN_kisisel, 1, 0);
            this.tblust.Controls.Add(this.panel1, 0, 0);
            this.tblust.Controls.Add(this.p_ust_sag, 2, 0);
            this.tblust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblust.Location = new System.Drawing.Point(0, 0);
            this.tblust.Name = "tblust";
            this.tblust.RowCount = 1;
            this.tblust.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblust.Size = new System.Drawing.Size(1146, 80);
            this.tblust.TabIndex = 0;
            this.tblust.DoubleClick += new System.EventHandler(this.button2_Click);
            this.tblust.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblust_MouseDown);
            this.tblust.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblust_MouseMove);
            this.tblust.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblust_MouseUp);
            // 
            // PN_kisisel
            // 
            this.PN_kisisel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.PN_kisisel.Controls.Add(this.LL_cikis);
            this.PN_kisisel.Controls.Add(this.LL_hesap);
            this.PN_kisisel.Controls.Add(this.pictureBox1);
            this.PN_kisisel.Controls.Add(this.LB_adsoyad_pn);
            this.PN_kisisel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PN_kisisel.Location = new System.Drawing.Point(759, 3);
            this.PN_kisisel.Name = "PN_kisisel";
            this.PN_kisisel.Size = new System.Drawing.Size(254, 74);
            this.PN_kisisel.TabIndex = 0;
            // 
            // LL_cikis
            // 
            this.LL_cikis.ActiveLinkColor = System.Drawing.Color.White;
            this.LL_cikis.AutoSize = true;
            this.LL_cikis.DisabledLinkColor = System.Drawing.Color.White;
            this.LL_cikis.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LL_cikis.ForeColor = System.Drawing.Color.White;
            this.LL_cikis.LinkColor = System.Drawing.Color.White;
            this.LL_cikis.Location = new System.Drawing.Point(209, 48);
            this.LL_cikis.Name = "LL_cikis";
            this.LL_cikis.Size = new System.Drawing.Size(33, 15);
            this.LL_cikis.TabIndex = 3;
            this.LL_cikis.TabStop = true;
            this.LL_cikis.Text = "Çıkış";
            this.LL_cikis.VisitedLinkColor = System.Drawing.Color.White;
            this.LL_cikis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_cikis_LinkClicked);
            // 
            // LL_hesap
            // 
            this.LL_hesap.ActiveLinkColor = System.Drawing.Color.White;
            this.LL_hesap.AutoSize = true;
            this.LL_hesap.DisabledLinkColor = System.Drawing.Color.White;
            this.LL_hesap.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LL_hesap.ForeColor = System.Drawing.Color.White;
            this.LL_hesap.LinkColor = System.Drawing.Color.White;
            this.LL_hesap.Location = new System.Drawing.Point(78, 48);
            this.LL_hesap.Name = "LL_hesap";
            this.LL_hesap.Size = new System.Drawing.Size(86, 15);
            this.LL_hesap.TabIndex = 2;
            this.LL_hesap.TabStop = true;
            this.LL_hesap.Text = "Hesap Ayarları";
            this.LL_hesap.VisitedLinkColor = System.Drawing.Color.White;
            this.LL_hesap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_hesap_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AracKiralama.Properties.Resources.smile_;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LB_adsoyad_pn
            // 
            this.LB_adsoyad_pn.AutoSize = true;
            this.LB_adsoyad_pn.Font = new System.Drawing.Font("Futura Md BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LB_adsoyad_pn.ForeColor = System.Drawing.Color.White;
            this.LB_adsoyad_pn.Location = new System.Drawing.Point(78, 12);
            this.LB_adsoyad_pn.Name = "LB_adsoyad_pn";
            this.LB_adsoyad_pn.Size = new System.Drawing.Size(74, 18);
            this.LB_adsoyad_pn.TabIndex = 0;
            this.LB_adsoyad_pn.Text = "Ad Soyad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 74);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "MARKA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Araç Kiralama";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AracKiralama.Properties.Resources.ucgen;
            this.pictureBox2.Location = new System.Drawing.Point(-10, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // p_ust_sag
            // 
            this.p_ust_sag.Controls.Add(this.BTN_zaman);
            this.p_ust_sag.Controls.Add(this.BTN_kapat);
            this.p_ust_sag.Controls.Add(this.button1);
            this.p_ust_sag.Controls.Add(this.BTN_boyut);
            this.p_ust_sag.Controls.Add(this.BTN_kucult);
            this.p_ust_sag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_ust_sag.Location = new System.Drawing.Point(1019, 3);
            this.p_ust_sag.Name = "p_ust_sag";
            this.p_ust_sag.Size = new System.Drawing.Size(124, 74);
            this.p_ust_sag.TabIndex = 4;
            // 
            // BTN_zaman
            // 
            this.BTN_zaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.BTN_zaman.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_zaman.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_zaman.FlatAppearance.BorderSize = 0;
            this.BTN_zaman.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.BTN_zaman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(145)))));
            this.BTN_zaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_zaman.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_zaman.ForeColor = System.Drawing.Color.White;
            this.BTN_zaman.Location = new System.Drawing.Point(0, 36);
            this.BTN_zaman.Name = "BTN_zaman";
            this.BTN_zaman.Size = new System.Drawing.Size(124, 38);
            this.BTN_zaman.TabIndex = 5;
            this.BTN_zaman.Text = "SS:DD\r\nDD/AA/YYYY";
            this.BTN_zaman.UseVisualStyleBackColor = false;
            // 
            // BTN_kapat
            // 
            this.BTN_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(9)))), ((int)(((byte)(27)))));
            this.BTN_kapat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_kapat.FlatAppearance.BorderSize = 0;
            this.BTN_kapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.BTN_kapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.BTN_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_kapat.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_kapat.ForeColor = System.Drawing.Color.White;
            this.BTN_kapat.Location = new System.Drawing.Point(99, 1);
            this.BTN_kapat.Name = "BTN_kapat";
            this.BTN_kapat.Size = new System.Drawing.Size(24, 29);
            this.BTN_kapat.TabIndex = 0;
            this.BTN_kapat.Text = "X";
            this.ttAciklama.SetToolTip(this.BTN_kapat, "Programı Kapat");
            this.BTN_kapat.UseVisualStyleBackColor = false;
            this.BTN_kapat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(145)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "?";
            this.ttAciklama.SetToolTip(this.button1, "Program Hakkında");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_boyut
            // 
            this.BTN_boyut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.BTN_boyut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_boyut.FlatAppearance.BorderSize = 0;
            this.BTN_boyut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.BTN_boyut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(145)))));
            this.BTN_boyut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_boyut.ForeColor = System.Drawing.Color.White;
            this.BTN_boyut.Location = new System.Drawing.Point(67, 1);
            this.BTN_boyut.Name = "BTN_boyut";
            this.BTN_boyut.Size = new System.Drawing.Size(24, 29);
            this.BTN_boyut.TabIndex = 1;
            this.BTN_boyut.Text = "♥";
            this.ttAciklama.SetToolTip(this.BTN_boyut, "Ekranı Kapla/Aşağı Getir");
            this.BTN_boyut.UseVisualStyleBackColor = false;
            this.BTN_boyut.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_kucult
            // 
            this.BTN_kucult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.BTN_kucult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_kucult.FlatAppearance.BorderSize = 0;
            this.BTN_kucult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.BTN_kucult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(145)))));
            this.BTN_kucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_kucult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_kucult.ForeColor = System.Drawing.Color.White;
            this.BTN_kucult.Location = new System.Drawing.Point(34, 1);
            this.BTN_kucult.Name = "BTN_kucult";
            this.BTN_kucult.Size = new System.Drawing.Size(24, 29);
            this.BTN_kucult.TabIndex = 2;
            this.BTN_kucult.Text = "__";
            this.ttAciklama.SetToolTip(this.BTN_kucult, "Simge Durumuna Küçült");
            this.BTN_kucult.UseVisualStyleBackColor = false;
            this.BTN_kucult.Click += new System.EventHandler(this.BTN_kucult_Click);
            // 
            // p_sol
            // 
            this.p_sol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.p_sol.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_sol.Location = new System.Drawing.Point(0, 80);
            this.p_sol.Name = "p_sol";
            this.p_sol.Size = new System.Drawing.Size(200, 508);
            this.p_sol.TabIndex = 1;
            this.p_sol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblust_MouseDown);
            this.p_sol.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblust_MouseMove);
            this.p_sol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblust_MouseUp);
            // 
            // T_zaman
            // 
            this.T_zaman.Enabled = true;
            this.T_zaman.Interval = 1000;
            this.T_zaman.Tick += new System.EventHandler(this.T_zaman_Tick);
            // 
            // PNana
            // 
            this.PNana.BackColor = System.Drawing.Color.White;
            this.PNana.BackgroundImage = global::AracKiralama.Properties.Resources.banner1;
            this.PNana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PNana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNana.Location = new System.Drawing.Point(200, 80);
            this.PNana.Name = "PNana";
            this.PNana.Size = new System.Drawing.Size(946, 508);
            this.PNana.TabIndex = 2;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(284, 261);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(276, 232);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(284, 261);
            this.metroTabControl2.TabIndex = 0;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(276, 232);
            this.metroTabPage2.TabIndex = 0;
            this.metroTabPage2.Text = "metroTabPage1";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroTabControl3
            // 
            this.metroTabControl3.Controls.Add(this.metroTabPage3);
            this.metroTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl3.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl3.Name = "metroTabControl3";
            this.metroTabControl3.SelectedIndex = 0;
            this.metroTabControl3.Size = new System.Drawing.Size(284, 261);
            this.metroTabControl3.TabIndex = 0;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(276, 232);
            this.metroTabPage3.TabIndex = 0;
            this.metroTabPage3.Text = "metroTabPage1";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroTabControl4
            // 
            this.metroTabControl4.Controls.Add(this.metroTabPage4);
            this.metroTabControl4.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl4.Name = "metroTabControl4";
            this.metroTabControl4.SelectedIndex = 0;
            this.metroTabControl4.Size = new System.Drawing.Size(200, 100);
            this.metroTabControl4.TabIndex = 0;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(192, 71);
            this.metroTabPage4.TabIndex = 0;
            this.metroTabPage4.Text = "metroTabPage1";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1146, 588);
            this.Controls.Add(this.PNana);
            this.Controls.Add(this.p_sol);
            this.Controls.Add(this.p_ust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_ust.ResumeLayout(false);
            this.tblust.ResumeLayout(false);
            this.PN_kisisel.ResumeLayout(false);
            this.PN_kisisel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.p_ust_sag.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabControl3.ResumeLayout(false);
            this.metroTabControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_ust;
        private System.Windows.Forms.Panel p_sol;
        private System.Windows.Forms.TableLayoutPanel tblust;
        private System.Windows.Forms.Button BTN_boyut;
        private System.Windows.Forms.Button BTN_kucult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_ust_sag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PN_kisisel;
        private System.Windows.Forms.LinkLabel LL_cikis;
        private System.Windows.Forms.LinkLabel LL_hesap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_adsoyad_pn;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button BTN_zaman;
        private System.Windows.Forms.Button BTN_kapat;
        private System.Windows.Forms.Timer T_zaman;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabControl metroTabControl3;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabControl metroTabControl4;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.Panel PNana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttAciklama;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

