namespace AracKiralama
{
    partial class KullaniciAyar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMS_sagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PN_chkbox = new System.Windows.Forms.Panel();
            this.TB_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_kaydet = new System.Windows.Forms.Button();
            this.TB_eposta = new System.Windows.Forms.TextBox();
            this.TB_telefon = new System.Windows.Forms.TextBox();
            this.TB_isimsoyisim = new System.Windows.Forms.TextBox();
            this.TB_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EP_hata = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.CMS_sagtik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.CMS_sagtik;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(785, 431);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Personel No";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kullanıcı Adı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-posta";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 150;
            // 
            // CMS_sagtik
            // 
            this.CMS_sagtik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.CMS_sagtik.Name = "CMS_sagtik";
            this.CMS_sagtik.Size = new System.Drawing.Size(117, 70);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // PN_chkbox
            // 
            this.PN_chkbox.Location = new System.Drawing.Point(374, 38);
            this.PN_chkbox.Name = "PN_chkbox";
            this.PN_chkbox.Size = new System.Drawing.Size(366, 284);
            this.PN_chkbox.TabIndex = 11;
            // 
            // TB_sifre
            // 
            this.TB_sifre.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_sifre.Location = new System.Drawing.Point(123, 154);
            this.TB_sifre.MaxLength = 20;
            this.TB_sifre.Name = "TB_sifre";
            this.TB_sifre.Size = new System.Drawing.Size(198, 23);
            this.TB_sifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şifre :";
            // 
            // BTN_kaydet
            // 
            this.BTN_kaydet.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_kaydet.Location = new System.Drawing.Point(646, 339);
            this.BTN_kaydet.Name = "BTN_kaydet";
            this.BTN_kaydet.Size = new System.Drawing.Size(110, 49);
            this.BTN_kaydet.TabIndex = 8;
            this.BTN_kaydet.Text = "Oluştur";
            this.BTN_kaydet.UseVisualStyleBackColor = true;
            this.BTN_kaydet.Click += new System.EventHandler(this.BTN_kaydet_Click);
            // 
            // TB_eposta
            // 
            this.TB_eposta.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_eposta.Location = new System.Drawing.Point(123, 125);
            this.TB_eposta.MaxLength = 100;
            this.TB_eposta.Name = "TB_eposta";
            this.TB_eposta.Size = new System.Drawing.Size(198, 23);
            this.TB_eposta.TabIndex = 4;
            // 
            // TB_telefon
            // 
            this.TB_telefon.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_telefon.Location = new System.Drawing.Point(123, 96);
            this.TB_telefon.MaxLength = 11;
            this.TB_telefon.Name = "TB_telefon";
            this.TB_telefon.Size = new System.Drawing.Size(198, 23);
            this.TB_telefon.TabIndex = 3;
            // 
            // TB_isimsoyisim
            // 
            this.TB_isimsoyisim.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_isimsoyisim.Location = new System.Drawing.Point(123, 67);
            this.TB_isimsoyisim.MaxLength = 250;
            this.TB_isimsoyisim.Name = "TB_isimsoyisim";
            this.TB_isimsoyisim.Size = new System.Drawing.Size(198, 23);
            this.TB_isimsoyisim.TabIndex = 2;
            // 
            // TB_kullaniciadi
            // 
            this.TB_kullaniciadi.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_kullaniciadi.Location = new System.Drawing.Point(123, 38);
            this.TB_kullaniciadi.MaxLength = 20;
            this.TB_kullaniciadi.Name = "TB_kullaniciadi";
            this.TB_kullaniciadi.Size = new System.Drawing.Size(198, 23);
            this.TB_kullaniciadi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(59, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-posta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // EP_hata
            // 
            this.EP_hata.ContainerControl = this;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(793, 460);
            this.metroTabControl1.TabIndex = 3;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.listView1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarSize = 0;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(785, 431);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tüm Personeller";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarSize = 0;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroToggle1);
            this.metroTabPage2.Controls.Add(this.PN_chkbox);
            this.metroTabPage2.Controls.Add(this.TB_sifre);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.BTN_kaydet);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.TB_eposta);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.TB_telefon);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.TB_isimsoyisim);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.TB_kullaniciadi);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(785, 431);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Yeni Personel";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.Location = new System.Drawing.Point(123, 183);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(50, 17);
            this.metroToggle1.TabIndex = 12;
            this.metroToggle1.Text = "On";
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // KullaniciAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(793, 460);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciAyar";
            this.Text = "KullaniciAyar";
            this.Load += new System.EventHandler(this.KullaniciAyar_Load);
            this.CMS_sagtik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PN_chkbox;
        private System.Windows.Forms.TextBox TB_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_kaydet;
        private System.Windows.Forms.TextBox TB_eposta;
        private System.Windows.Forms.TextBox TB_telefon;
        private System.Windows.Forms.TextBox TB_isimsoyisim;
        private System.Windows.Forms.TextBox TB_kullaniciadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider EP_hata;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip CMS_sagtik;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroToggle metroToggle1;
    }
}