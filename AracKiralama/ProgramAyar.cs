using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class ProgramAyar : Form
    {
        public ProgramAyar()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = rbYerel.Checked;
            groupBox2.Enabled = rbSunucu.Checked;
            button1.Enabled = false;
        }



        private void ProgramAyar_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.sunucu;
            textBox2.Text = Properties.Settings.Default.yvt;
        }
        public class tablolar
        {
            public string tableName { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string baglanti = "";
            if (rbYerel.Checked)
            {
                baglanti = @"Data Source="+textBox1.Text+ ";Initial Catalog=" + textBox2.Text + ";Integrated Security=True";

            }
            else
            {
                baglanti = @"Data Source =" + textBox4.Text + "; Initial Catalog = " + textBox3.Text + "; User ID = " + textBox5.Text + "; Password = " + textBox6.Text + "; Integrated Security = false";
            }


            try
            {
                List<string> gelentablo = new List<string>();
                string[] tablolar = new string[] { "araba","izinler","kiralama","menu","musteri","personel","sigorta"};
                List<string> olmayanlar = new List<string>();
                string olmayan = "";
                SqlConnection conn= new SqlConnection(baglanti);
                SqlCommand komut = new SqlCommand("select * from sys.tables", conn);
                conn.Open();
                SqlDataReader dr = komut.ExecuteReader();
                for (int i =0; dr.Read();i++)
                {
                    gelentablo.Add(dr["name"].ToString());                    
                }
                conn.Close();
                for (int j = 0; j < tablolar.Length; j++)
                {
                    int a = gelentablo.IndexOf(tablolar[j]);
                    if ( a== -1)
                    {
                        olmayanlar.Add(tablolar[j]);
                        olmayan = olmayan + "\n-" + tablolar[j];
                    }
                }
                if (olmayanlar.Count>0)
                {
                    MessageBox.Show("Veritabanı Bağlantısı Başarılı\nEksik Tablolar Var\n"+olmayan, Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Veritabanı Bağlantısı Başarılı!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    button1.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = false;
            }
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baglanti = "";
            if (rbYerel.Checked)
            {
                baglanti = @"Data Source=" + textBox1.Text + ";Initial Catalog=" + textBox2.Text + ";Integrated Security=True";
                Properties.Settings.Default.Baglanti = baglanti;
                Properties.Settings.Default.sunucu = textBox1.Text;
                Properties.Settings.Default.yvt = textBox2.Text;
                Properties.Settings.Default.ip = "";
                Properties.Settings.Default.svt = "";
                Properties.Settings.Default.kullanici = "";
                Properties.Settings.Default.sifre = "";
                Properties.Settings.Default.Save();
            }
            else
            {
                baglanti = @"Data Source =" + textBox4.Text + "; Initial Catalog = " + textBox3.Text + "; User ID = " + textBox5.Text + "; Password = " + textBox6.Text + "; Integrated Security = false";
                Properties.Settings.Default.Baglanti = baglanti;
                Properties.Settings.Default.sunucu = "";
                Properties.Settings.Default.yvt = "";
                Properties.Settings.Default.ip = textBox4.Text;
                Properties.Settings.Default.svt = textBox3.Text;
                Properties.Settings.Default.kullanici =textBox5.Text;
                Properties.Settings.Default.sifre = textBox6.Text;
                Properties.Settings.Default.Save();
            }
            MessageBox.Show("Değişiklikler kaydedildi\nYaptığınız değişikliğin geçerli olması için yeniden başlatılması gerekiyor!", Properties.Settings.Default.ProgAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }
    }
}
