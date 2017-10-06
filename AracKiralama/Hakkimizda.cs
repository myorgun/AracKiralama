using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class Hakkimizda : Form
    {
        public Hakkimizda()
        {
            InitializeComponent();
        }

        private void Hakkimizda_Load(object sender, EventArgs e)
        {
            GraphicsPath grp = new GraphicsPath();
            grp.AddEllipse(0, 0, this.Width, this.Height);
            Region rgp = new Region(grp);
            this.Region = rgp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
