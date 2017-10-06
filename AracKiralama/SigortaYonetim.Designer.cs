namespace AracKiralama
{
    partial class SigortaYonetim
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
            this.sayfa1 = new MetroFramework.Controls.MetroTabPage();
            this.lvSigorta = new System.Windows.Forms.ListView();
            this.Araba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sayfa2 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAraba = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EP_hata = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabControl1.SuspendLayout();
            this.sayfa1.SuspendLayout();
            this.sayfa2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraba)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.sayfa1);
            this.metroTabControl1.Controls.Add(this.sayfa2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(947, 423);
            this.metroTabControl1.TabIndex = 0;
            // 
            // sayfa1
            // 
            this.sayfa1.Controls.Add(this.lvSigorta);
            this.sayfa1.HorizontalScrollbarBarColor = true;
            this.sayfa1.HorizontalScrollbarSize = 0;
            this.sayfa1.Location = new System.Drawing.Point(4, 25);
            this.sayfa1.Name = "sayfa1";
            this.sayfa1.Size = new System.Drawing.Size(939, 394);
            this.sayfa1.TabIndex = 0;
            this.sayfa1.Text = "Tüm Araç Sigortaları";
            this.sayfa1.VerticalScrollbarBarColor = true;
            this.sayfa1.VerticalScrollbarSize = 0;
            // 
            // lvSigorta
            // 
            this.lvSigorta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Araba,
            this.Marka,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvSigorta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSigorta.FullRowSelect = true;
            this.lvSigorta.HideSelection = false;
            this.lvSigorta.Location = new System.Drawing.Point(0, 0);
            this.lvSigorta.Name = "lvSigorta";
            this.lvSigorta.Size = new System.Drawing.Size(939, 394);
            this.lvSigorta.TabIndex = 4;
            this.lvSigorta.UseCompatibleStateImageBehavior = false;
            this.lvSigorta.View = System.Windows.Forms.View.Details;
            // 
            // Araba
            // 
            this.Araba.Text = "Araba";
            this.Araba.Width = 150;
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sigorta Başlangıç Tarihi";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Sigorta Bitiş Tarihi";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Yıllık Tutar";
            this.columnHeader11.Width = 100;
            // 
            // sayfa2
            // 
            this.sayfa2.Controls.Add(this.tableLayoutPanel1);
            this.sayfa2.HorizontalScrollbarBarColor = true;
            this.sayfa2.HorizontalScrollbarSize = 0;
            this.sayfa2.Location = new System.Drawing.Point(4, 25);
            this.sayfa2.Name = "sayfa2";
            this.sayfa2.Size = new System.Drawing.Size(939, 394);
            this.sayfa2.TabIndex = 1;
            this.sayfa2.Text = "Sigorta Girişi";
            this.sayfa2.VerticalScrollbarBarColor = true;
            this.sayfa2.VerticalScrollbarSize = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.dgvAraba, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 394);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvAraba
            // 
            this.dgvAraba.AllowUserToAddRows = false;
            this.dgvAraba.AllowUserToDeleteRows = false;
            this.dgvAraba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvAraba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAraba.Location = new System.Drawing.Point(3, 3);
            this.dgvAraba.MultiSelect = false;
            this.dgvAraba.Name = "dgvAraba";
            this.dgvAraba.ReadOnly = true;
            this.dgvAraba.RowHeadersWidth = 20;
            this.dgvAraba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAraba.Size = new System.Drawing.Size(557, 388);
            this.dgvAraba.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbTutar);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(566, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 388);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sigorta Başlama Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sigorta Bitiş Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tutar :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(155, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(155, 139);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(200, 22);
            this.tbTutar.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EP_hata
            // 
            this.EP_hata.ContainerControl = this;
            // 
            // SigortaYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 423);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SigortaYonetim";
            this.Text = "SigortaYonetim";
            this.Load += new System.EventHandler(this.SigortaYonetim_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.sayfa1.ResumeLayout(false);
            this.sayfa2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraba)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage sayfa1;
        private MetroFramework.Controls.MetroTabPage sayfa2;
        private System.Windows.Forms.ListView lvSigorta;
        private System.Windows.Forms.ColumnHeader Araba;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvAraba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider EP_hata;
    }
}