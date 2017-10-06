namespace AracKiralama
{
    partial class Kiralamalar
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lvKiradakiler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaİptalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lvGecmis = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaİptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(791, 449);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lvKiradakiler);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarSize = 0;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(783, 420);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Kiradakiler";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarSize = 0;
            // 
            // lvKiradakiler
            // 
            this.lvKiradakiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvKiradakiler.ContextMenuStrip = this.contextMenuStrip2;
            this.lvKiradakiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKiradakiler.FullRowSelect = true;
            this.lvKiradakiler.Location = new System.Drawing.Point(0, 0);
            this.lvKiradakiler.MultiSelect = false;
            this.lvKiradakiler.Name = "lvKiradakiler";
            this.lvKiradakiler.Size = new System.Drawing.Size(783, 420);
            this.lvKiradakiler.TabIndex = 2;
            this.lvKiradakiler.UseCompatibleStateImageBehavior = false;
            this.lvKiradakiler.View = System.Windows.Forms.View.Details;
            this.lvKiradakiler.DoubleClick += new System.EventHandler(this.detayGörToolStripMenuItem_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Araç";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Başlangıç Tarihi";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bitiş Tarihi";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kiralayan Personel";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Toplam Tutar";
            this.columnHeader6.Width = 130;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayGörToolStripMenuItem,
            this.kiralamaİptalToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(147, 48);
            // 
            // detayGörToolStripMenuItem
            // 
            this.detayGörToolStripMenuItem.Name = "detayGörToolStripMenuItem";
            this.detayGörToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.detayGörToolStripMenuItem.Text = "Detay Gör";
            this.detayGörToolStripMenuItem.Click += new System.EventHandler(this.detayGörToolStripMenuItem_Click);
            // 
            // kiralamaİptalToolStripMenuItem1
            // 
            this.kiralamaİptalToolStripMenuItem1.Name = "kiralamaİptalToolStripMenuItem1";
            this.kiralamaİptalToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.kiralamaİptalToolStripMenuItem1.Text = "Kiralama İptal";
            this.kiralamaİptalToolStripMenuItem1.Click += new System.EventHandler(this.kiralamaİptalToolStripMenuItem1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.lvGecmis);
            this.metroTabPage2.Controls.Add(this.tableLayoutPanel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarSize = 0;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 25);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(783, 420);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Kiralama Geçmişi";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarSize = 0;
            // 
            // lvGecmis
            // 
            this.lvGecmis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvGecmis.ContextMenuStrip = this.contextMenuStrip1;
            this.lvGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGecmis.FullRowSelect = true;
            this.lvGecmis.Location = new System.Drawing.Point(0, 70);
            this.lvGecmis.MultiSelect = false;
            this.lvGecmis.Name = "lvGecmis";
            this.lvGecmis.Size = new System.Drawing.Size(783, 350);
            this.lvGecmis.TabIndex = 3;
            this.lvGecmis.UseCompatibleStateImageBehavior = false;
            this.lvGecmis.View = System.Windows.Forms.View.Details;
            this.lvGecmis.DoubleClick += new System.EventHandler(this.detayToolStripMenuItem_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Araç";
            this.columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Müşteri";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Başlangıç Tarihi";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Bitiş Tarihi";
            this.columnHeader10.Width = 130;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Kiralayan Personel";
            this.columnHeader11.Width = 130;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Toplam Tutar";
            this.columnHeader12.Width = 130;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayToolStripMenuItem,
            this.kiralamaİptalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // detayToolStripMenuItem
            // 
            this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
            this.detayToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.detayToolStripMenuItem.Text = "Detay Gör";
            this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click);
            // 
            // kiralamaİptalToolStripMenuItem
            // 
            this.kiralamaİptalToolStripMenuItem.Name = "kiralamaİptalToolStripMenuItem";
            this.kiralamaİptalToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.kiralamaİptalToolStripMenuItem.Text = "Kiralama İptal";
            this.kiralamaİptalToolStripMenuItem.Click += new System.EventHandler(this.kiralamaİptalToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 70);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(198, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 64);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Kısıtı";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Filitrele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Teslim Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kiralama Tarihi:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(92, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(190, 21);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 21);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Kiralamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 449);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kiralamalar";
            this.Text = "Kiralamalar";
            this.Load += new System.EventHandler(this.Kiralamalar_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.ListView lvKiradakiler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvGecmis;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem detayGörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaİptalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaİptalToolStripMenuItem1;
    }
}