using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_Model
{
    public class Futbolcu
    {
        public int FutbolcuID { get; set; }
        public string FutbolcuAd { get; set; }
        public string FutbolcuSoyad { get; set; }
        public byte FutbolcuYas { get; set; }
        public byte  FutbolcuYetenek { get; set; }
        public decimal FutbolcuDeger { get; set; }
        public int TakimID { get; set; }
    }
}
