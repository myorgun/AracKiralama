namespace AracKiralama
{
    partial class MusteriGuncelle
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
            this.TB_eposta = new System.Windows.Forms.TextBox();
            this.TB_telefon = new System.Windows.Forms.TextBox();
            this.TB_isim = new System.Windows.Forms.TextBox();
            this.TB_tcno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_mustno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EP_hata = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_epuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_eyil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).BeginInit();
            this.SuspendLayout();
            // 
            // NUD_epuan
            // 
            this.NUD_epuan.Location = new System.Drawing.Point(459, 168);
            this.NUD_epuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_epuan.Name = "NUD_epuan";
            this.NUD_epuan.Size = new System.Drawing.Size(200, 20);
            this.NUD_epuan.TabIndex = 34;
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
            this.label11.Location = new System.Drawing.Point(366, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Ehliyet Puanı :";
            // 
            // NUD_eyil
            // 
            this.NUD_eyil.Location = new System.Drawing.Point(459, 140);
            this.NUD_eyil.Maximum = new decimal(new int[] {
            2020,
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
            this.NUD_eyil.TabIndex = 33;
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
            this.CB_cins.Location = new System.Drawing.Point(459, 52);
            this.CB_cins.Name = "CB_cins";
            this.CB_cins.Size = new System.Drawing.Size(200, 21);
            this.CB_cins.TabIndex = 31;
            // 
            // DTP_dtar
            // 
            this.DTP_dtar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_dtar.Location = new System.Drawing.Point(459, 27);
            this.DTP_dtar.Name = "DTP_dtar";
            this.DTP_dtar.Size = new System.Drawing.Size(200, 20);
            this.DTP_dtar.TabIndex = 30;
            this.DTP_dtar.ValueChanged += new System.EventHandler(this.DTP_dtar_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Doğum Tarihi :";
            // 
            // TB_soyad
            // 
            this.TB_soyad.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_soyad.Location = new System.Drawing.Point(116, 114);
            this.TB_soyad.MaxLength = 50;
            this.TB_soyad.Name = "TB_soyad";
            this.TB_soyad.Size = new System.Drawing.Size(198, 23);
            this.TB_soyad.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(57, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Soyadı :";
            // 
            // TB_adres
            // 
            this.TB_adres.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_adres.Location = new System.Drawing.Point(116, 201);
            this.TB_adres.Multiline = true;
            this.TB_adres.Name = "TB_adres";
            this.TB_adres.Size = new System.Drawing.Size(198, 102);
            this.TB_adres.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(381, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ehliyet Yılı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(398, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ehliyeti :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(391, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Cinsiyeti :";
            // 
            // TB_ehliyet
            // 
            this.TB_ehliyet.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_ehliyet.Location = new System.Drawing.Point(459, 111);
            this.TB_ehliyet.Name = "TB_ehliyet";
            this.TB_ehliyet.Size = new System.Drawing.Size(200, 23);
            this.TB_ehliyet.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(59, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Adresi :";
            // 
            // TB_eposta
            // 
            this.TB_eposta.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_eposta.Location = new System.Drawing.Point(116, 172);
            this.TB_eposta.MaxLength = 100;
            this.TB_eposta.Name = "TB_eposta";
            this.TB_eposta.Size = new System.Drawing.Size(198, 23);
            this.TB_eposta.TabIndex = 28;
            // 
            // TB_telefon
            // 
            this.TB_telefon.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_telefon.Location = new System.Drawing.Point(116, 143);
            this.TB_telefon.MaxLength = 11;
            this.TB_telefon.Name = "TB_telefon";
            this.TB_telefon.Size = new System.Drawing.Size(198, 23);
            this.TB_telefon.TabIndex = 27;
            // 
            // TB_isim
            // 
            this.TB_isim.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_isim.Location = new System.Drawing.Point(116, 84);
            this.TB_isim.MaxLength = 50;
            this.TB_isim.Name = "TB_isim";
            this.TB_isim.Size = new System.Drawing.Size(198, 23);
            this.TB_isim.TabIndex = 25;
            // 
            // TB_tcno
            // 
            this.TB_tcno.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_tcno.Location = new System.Drawing.Point(116, 55);
            this.TB_tcno.MaxLength = 11;
            this.TB_tcno.Name = "TB_tcno";
            this.TB_tcno.Size = new System.Drawing.Size(198, 23);
            this.TB_tcno.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "E-posta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "TC Kimlik No :";
            // 
            // TB_mustno
            // 
            this.TB_mustno.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_mustno.Location = new System.Drawing.Point(116, 24);
            this.TB_mustno.MaxLength = 11;
            this.TB_mustno.Name = "TB_mustno";
            this.TB_mustno.ReadOnly = true;
            this.TB_mustno.Size = new System.Drawing.Size(198, 23);
            this.TB_mustno.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(19, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Müşteri No :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 48;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EP_hata
            // 
            this.EP_hata.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(505, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 33);
            this.button2.TabIndex = 49;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusteriGuncelle
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(702, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_mustno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NUD_epuan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NUD_eyil);
            this.Controls.Add(this.CB_cins);
            this.Controls.Add(this.DTP_dtar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_soyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_adres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_ehliyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_eposta);
            this.Controls.Add(this.TB_telefon);
            this.Controls.Add(this.TB_isim);
            this.Controls.Add(this.TB_tcno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MusteriGuncelle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Güncelle";
            this.Load += new System.EventHandler(this.MusteriGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_epuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_eyil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_hata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox TB_eposta;
        private System.Windows.Forms.TextBox TB_telefon;
        private System.Windows.Forms.TextBox TB_isim;
        private System.Windows.Forms.TextBox TB_tcno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_mustno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider EP_hata;
        private System.Windows.Forms.Button button2;
    }
}