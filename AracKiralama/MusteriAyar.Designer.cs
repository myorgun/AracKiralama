namespace AracKiralama
{
    partial class MusteriAyar
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
            this.EP_hata = new System.Windows.Forms.ErrorProvider(this.components);
            this.NUD_epuan = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NUD_eyil = new System.Windows.Forms.NumericUpDown();
            this.CB_cins = new System.Windows.Forms.ComboBox();
            this.DTP_dtar = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_soyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_adres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_ehliyet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_kaydet = new System.Windows.Forms.Button();
            this.TB_eposta = new System.Windows.Forms.TextBox();
            this.TB_telefon = new System.Windows.Forms.TextBox();
            this.TB_isim = new System.Windows.Forms.TextBox();
            this.TB_tcno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_sagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_epuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_eyil)).BeginInit();
            this.CMS_sagtik.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EP_hata
            // 
            this.EP_hata.ContainerControl = this;
            // 
            // NUD_epuan
            // 
            this.NUD_epuan.Location = new System.Drawing.Point(471, 177);
            this.NUD_epuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_epuan.Name = "NUD_epuan";
            this.NUD_epuan.Size = new System.Drawing.Size(200, 20);
            this.NUD_epuan.TabIndex = 11;
            this.NUD_epuan.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(378, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ehliyet Puanı :";
            // 
            // NUD_eyil
            // 
            this.NUD_eyil.Location = new System.Drawing.Point(471, 149);
            this.NUD_eyil.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.NUD_eyil.Minimum = new decimal(new int[] {
            1956,
            0,
            0,
            0});
            this.NUD_eyil.Name = "NUD_eyil";
            this.NUD_eyil.Size = new System.Drawing.Size(200, 20);
            this.NUD_eyil.TabIndex = 10;
            this.NUD_eyil.Value = new decimal(new int[] {
            1956,
            0,
            0,
            0});
            // 
            // CB_cins
            // 
            this.CB_cins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_cins.FormattingEnabled = true;
            this.CB_cins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CB_cins.Location = new System.Drawing.Point(471, 61);
            this.CB_cins.Name = "CB_cins";
            this.CB_cins.Size = new System.Drawing.Size(200, 21);
            this.CB_cins.TabIndex = 8;
            // 
            // DTP_dtar
            // 
            this.DTP_dtar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_dtar.Location = new System.Drawing.Point(471, 36);
            this.DTP_dtar.Name = "DTP_dtar";
            this.DTP_dtar.Size = new System.Drawing.Size(200, 20);
            this.DTP_dtar.TabIndex = 7;
            this.DTP_dtar.ValueChanged += new System.EventHandler(this.DTP_dtar_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Doğum Tarihi :";
            // 
            // TB_soyad
            // 
            this.TB_soyad.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_soyad.Location = new System.Drawing.Point(129, 95);
            this.TB_soyad.MaxLength = 50;
            this.TB_soyad.Name = "TB_soyad";
            this.TB_soyad.Size = new System.Drawing.Size(198, 23);
            this.TB_soyad.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(70, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Soyadı :";
            // 
            // TB_adres
            // 
            this.TB_adres.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_adres.Location = new System.Drawing.Point(129, 182);
            this.TB_adres.Multiline = true;
            this.TB_adres.Name = "TB_adres";
            this.TB_adres.Size = new System.Drawing.Size(198, 102);
            this.TB_adres.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(393, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ehliyet Yılı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(410, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ehliyeti :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(403, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cinsiyeti :";
            // 
            // TB_ehliyet
            // 
            this.TB_ehliyet.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_ehliyet.Location = new System.Drawing.Point(471, 120);
            this.TB_ehliyet.Name = "TB_ehliyet";
            this.TB_ehliyet.Size = new System.Drawing.Size(200, 23);
            this.TB_ehliyet.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adresi :";
            // 
            // BTN_kaydet
            // 
            this.BTN_kaydet.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_kaydet.Location = new System.Drawing.Point(556, 241);
            this.BTN_kaydet.Name = "BTN_kaydet";
            this.BTN_kaydet.Size = new System.Drawing.Size(115, 57);
            this.BTN_kaydet.TabIndex = 12;
            this.BTN_kaydet.Text = "Oluştur";
            this.BTN_kaydet.UseVisualStyleBackColor = true;
            this.BTN_kaydet.Click += new System.EventHandler(this.BTN_kaydet_Click);
            // 
            // TB_eposta
            // 
            this.TB_eposta.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_eposta.Location = new System.Drawing.Point(129, 153);
            this.TB_eposta.MaxLength = 100;
            this.TB_eposta.Name = "TB_eposta";
            this.TB_eposta.Size = new System.Drawing.Size(198, 23);
            this.TB_eposta.TabIndex = 5;
            // 
            // TB_telefon
            // 
            this.TB_telefon.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_telefon.Location = new System.Drawing.Point(129, 124);
            this.TB_telefon.MaxLength = 11;
            this.TB_telefon.Name = "TB_telefon";
            this.TB_telefon.Size = new System.Drawing.Size(198, 23);
            this.TB_telefon.TabIndex = 4;
            // 
            // TB_isim
            // 
            this.TB_isim.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_isim.Location = new System.Drawing.Point(129, 65);
            this.TB_isim.MaxLength = 50;
            this.TB_isim.Name = "TB_isim";
            this.TB_isim.Size = new System.Drawing.Size(198, 23);
            this.TB_isim.TabIndex = 2;
            // 
            // TB_tcno
            // 
            this.TB_tcno.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_tcno.Location = new System.Drawing.Point(129, 36);
            this.TB_tcno.MaxLength = 11;
            this.TB_tcno.Name = "TB_tcno";
            this.TB_tcno.Size = new System.Drawing.Size(198, 23);
            this.TB_tcno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "E-posta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "TC Kimlik No :";
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
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
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 150;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listView1.ContextMenuStrip = this.CMS_sagtik;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(858, 380);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Müşteri No";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC Kimlik No";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı Soyadı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-posta";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cinsiyet";
            this.columnHeader6.Width = 113;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(866, 409);
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.listView1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarSize = 0;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(858, 380);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tüm Müşteriler";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarSize = 0;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.NUD_epuan);
            this.metroTabPage2.Controls.Add(this.label11);
            this.metroTabPage2.Controls.Add(this.NUD_eyil);
            this.metroTabPage2.Controls.Add(this.TB_adres);
            this.metroTabPage2.Controls.Add(this.CB_cins);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.DTP_dtar);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.label10);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.TB_soyad);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.TB_tcno);
            this.metroTabPage2.Controls.Add(this.TB_isim);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.Controls.Add(this.TB_telefon);
            this.metroTabPage2.Controls.Add(this.label7);
            this.metroTabPage2.Controls.Add(this.TB_eposta);
            this.metroTabPage2.Controls.Add(this.label6);
            this.metroTabPage2.Controls.Add(this.BTN_kaydet);
            this.metroTabPage2.Controls.Add(this.TB_ehliyet);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(858, 380);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Yeni Müşteri";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // MusteriAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 409);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriAyar";
            this.Text = "MusteriAyar";
            this.Load += new System.EventHandler(this.MusteriAyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_epuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_eyil)).EndInit();
            this.CMS_sagtik.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider EP_hata;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip CMS_sagtik;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.Button BTN_kaydet;
        private System.Windows.Forms.TextBox TB_eposta;
        private System.Windows.Forms.TextBox TB_telefon;
        private System.Windows.Forms.TextBox TB_isim;
        private System.Windows.Forms.TextBox TB_tcno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.NumericUpDown NUD_epuan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NUD_eyil;
        private System.Windows.Forms.ComboBox CB_cins;
        private System.Windows.Forms.DateTimePicker DTP_dtar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_soyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_adres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_ehliyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}