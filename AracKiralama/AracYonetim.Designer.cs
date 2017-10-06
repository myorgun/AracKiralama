namespace AracKiralama
{
    partial class AracYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracYonetim));
            this.EP_hata = new System.Windows.Forms.ErrorProvider(this.components);
            this.CMS_sagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFDresimbul = new System.Windows.Forms.OpenFileDialog();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lvArabaList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBinternetten = new MetroFramework.Controls.MetroToggle();
            this.label5 = new System.Windows.Forms.Label();
            this.TBresiminternet = new System.Windows.Forms.TextBox();
            this.TBresimyol = new System.Windows.Forms.TextBox();
            this.BTgozat = new System.Windows.Forms.Button();
            this.PBarabaresim = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPlaka = new System.Windows.Forms.TextBox();
            this.NUD_fiyat = new System.Windows.Forms.NumericUpDown();
            this.NUD_yili = new System.Windows.Forms.NumericUpDown();
            this.BTN_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_marka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).BeginInit();
            this.CMS_sagtik.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBarabaresim)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_yili)).BeginInit();
            this.SuspendLayout();
            // 
            // EP_hata
            // 
            this.EP_hata.ContainerControl = this;
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
            // OFDresimbul
            // 
            this.OFDresimbul.Title = "Araç Resmini Seçin";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(895, 416);
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lvArabaList);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarSize = 0;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(887, 387);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Araçlar";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarSize = 0;
            // 
            // lvArabaList
            // 
            this.lvArabaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lvArabaList.ContextMenuStrip = this.CMS_sagtik;
            this.lvArabaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvArabaList.FullRowSelect = true;
            this.lvArabaList.HideSelection = false;
            this.lvArabaList.Location = new System.Drawing.Point(0, 0);
            this.lvArabaList.Name = "lvArabaList";
            this.lvArabaList.Size = new System.Drawing.Size(887, 387);
            this.lvArabaList.TabIndex = 3;
            this.lvArabaList.UseCompatibleStateImageBehavior = false;
            this.lvArabaList.View = System.Windows.Forms.View.Details;
            this.lvArabaList.DoubleClick += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            this.lvArabaList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvArabaList_KeyDown);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Araç Resim";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marka";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yılı";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyatı";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Plaka";
            this.columnHeader7.Width = 93;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.tableLayoutPanel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarSize = 0;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(887, 387);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Yeni Araç";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarSize = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.3936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.6064F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 324);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 318);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CBinternetten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TBresiminternet);
            this.groupBox1.Controls.Add(this.TBresimyol);
            this.groupBox1.Controls.Add(this.BTgozat);
            this.groupBox1.Controls.Add(this.PBarabaresim);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 318);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim Seç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "İnternetten Yükle";
            // 
            // CBinternetten
            // 
            this.CBinternetten.AutoSize = true;
            this.CBinternetten.DisplayStatus = false;
            this.CBinternetten.Location = new System.Drawing.Point(39, 255);
            this.CBinternetten.Name = "CBinternetten";
            this.CBinternetten.Size = new System.Drawing.Size(50, 17);
            this.CBinternetten.TabIndex = 15;
            this.CBinternetten.Text = "Off";
            this.CBinternetten.CheckedChanged += new System.EventHandler(this.CBinternetten_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(6, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resim Yolu :";
            // 
            // TBresiminternet
            // 
            this.TBresiminternet.Enabled = false;
            this.TBresiminternet.Location = new System.Drawing.Point(84, 280);
            this.TBresiminternet.Name = "TBresiminternet";
            this.TBresiminternet.Size = new System.Drawing.Size(223, 20);
            this.TBresiminternet.TabIndex = 13;
            // 
            // TBresimyol
            // 
            this.TBresimyol.Location = new System.Drawing.Point(6, 223);
            this.TBresimyol.Name = "TBresimyol";
            this.TBresimyol.ReadOnly = true;
            this.TBresimyol.Size = new System.Drawing.Size(220, 20);
            this.TBresimyol.TabIndex = 11;
            this.TBresimyol.Text = "Dosya Seçilmedi";
            // 
            // BTgozat
            // 
            this.BTgozat.Location = new System.Drawing.Point(232, 224);
            this.BTgozat.Name = "BTgozat";
            this.BTgozat.Size = new System.Drawing.Size(75, 23);
            this.BTgozat.TabIndex = 10;
            this.BTgozat.Text = "Gözat..";
            this.BTgozat.UseVisualStyleBackColor = true;
            this.BTgozat.Click += new System.EventHandler(this.button1_Click);
            // 
            // PBarabaresim
            // 
            this.PBarabaresim.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBarabaresim.Image = ((System.Drawing.Image)(resources.GetObject("PBarabaresim.Image")));
            this.PBarabaresim.Location = new System.Drawing.Point(3, 16);
            this.PBarabaresim.Name = "PBarabaresim";
            this.PBarabaresim.Size = new System.Drawing.Size(338, 200);
            this.PBarabaresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBarabaresim.TabIndex = 9;
            this.PBarabaresim.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbPlaka);
            this.panel2.Controls.Add(this.NUD_fiyat);
            this.panel2.Controls.Add(this.NUD_yili);
            this.panel2.Controls.Add(this.BTN_kaydet);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TB_model);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TB_marka);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(353, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 318);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(57, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Plaka :";
            // 
            // tbPlaka
            // 
            this.tbPlaka.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPlaka.Location = new System.Drawing.Point(112, 128);
            this.tbPlaka.MaxLength = 15;
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(198, 23);
            this.tbPlaka.TabIndex = 12;
            // 
            // NUD_fiyat
            // 
            this.NUD_fiyat.Font = new System.Drawing.Font("Futura Bk BT", 9.75F);
            this.NUD_fiyat.Location = new System.Drawing.Point(112, 99);
            this.NUD_fiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_fiyat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_fiyat.Name = "NUD_fiyat";
            this.NUD_fiyat.Size = new System.Drawing.Size(198, 23);
            this.NUD_fiyat.TabIndex = 10;
            this.NUD_fiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUD_yili
            // 
            this.NUD_yili.Font = new System.Drawing.Font("Futura Bk BT", 9.75F);
            this.NUD_yili.Location = new System.Drawing.Point(112, 70);
            this.NUD_yili.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.NUD_yili.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUD_yili.Name = "NUD_yili";
            this.NUD_yili.Size = new System.Drawing.Size(198, 23);
            this.NUD_yili.TabIndex = 9;
            this.NUD_yili.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // BTN_kaydet
            // 
            this.BTN_kaydet.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_kaydet.Location = new System.Drawing.Point(187, 274);
            this.BTN_kaydet.Name = "BTN_kaydet";
            this.BTN_kaydet.Size = new System.Drawing.Size(123, 32);
            this.BTN_kaydet.TabIndex = 8;
            this.BTN_kaydet.Text = "Oluştur";
            this.BTN_kaydet.UseVisualStyleBackColor = true;
            this.BTN_kaydet.Click += new System.EventHandler(this.BTN_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Marka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model :";
            // 
            // TB_model
            // 
            this.TB_model.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_model.Location = new System.Drawing.Point(112, 41);
            this.TB_model.MaxLength = 250;
            this.TB_model.Name = "TB_model";
            this.TB_model.Size = new System.Drawing.Size(198, 23);
            this.TB_model.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yılı :";
            // 
            // TB_marka
            // 
            this.TB_marka.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_marka.Location = new System.Drawing.Point(112, 12);
            this.TB_marka.MaxLength = 20;
            this.TB_marka.Name = "TB_marka";
            this.TB_marka.Size = new System.Drawing.Size(198, 23);
            this.TB_marka.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyatı (TL) :";
            // 
            // AracYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 416);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AracYonetim";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracYonetim";
            this.Load += new System.EventHandler(this.AracYonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).EndInit();
            this.CMS_sagtik.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBarabaresim)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_yili)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider EP_hata;
        private System.Windows.Forms.ContextMenuStrip CMS_sagtik;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OFDresimbul;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.ListView lvArabaList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBresiminternet;
        private System.Windows.Forms.TextBox TBresimyol;
        private System.Windows.Forms.Button BTgozat;
        private System.Windows.Forms.PictureBox PBarabaresim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPlaka;
        private System.Windows.Forms.NumericUpDown NUD_fiyat;
        private System.Windows.Forms.NumericUpDown NUD_yili;
        private System.Windows.Forms.Button BTN_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_marka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroToggle CBinternetten;
    }
}