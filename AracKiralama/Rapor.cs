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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        public string k_id ="0";
        private void Rapor_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.Baglanti);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kiralama inner join araba on kiralama.araba_id = araba.a_id inner join musteri on kiralama.musteri_id = musteri.m_id inner join personel on kiralama.personel_id = personel.p_id  where kiralama.k_id='" + k_id + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
