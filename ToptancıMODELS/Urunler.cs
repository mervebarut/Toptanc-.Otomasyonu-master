using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptancıMODELS
{
    class Urunler
    {
        string ad;
        
        public int Urun_ID{ get; set; }
        public string Ad { get => ad; set => ad = value.ToUpper(); }
        public int Kategori_ID { get ; set; }
        public int Firma_ID{ get; set; }
        public int Alis_Fİyat { get; set; }
        public int Satıs_Fiyat { get; set; }
        
    }
}
