using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama
{
    class Ayarlar
    {
        public string baglanti
        {
            get
            {
                return @Properties.Settings.Default.Baglanti;
            }
            
        } 
    }
}
