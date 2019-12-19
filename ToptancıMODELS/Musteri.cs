using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptancıMODELS
{
    public class Musteri
    {
        string ad;
        string soyad;
        public int Musteriid { get; set; }
        public string Ad { get => ad; set => ad = value.ToUpper(); }
        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }
        public string Telefon { get; set; }
        public string Sifre { get; set; }
        public string EPosta { get; set; }
        public string Adres { get; set; }
        public string TCKNo { get; set; }
    }
}
