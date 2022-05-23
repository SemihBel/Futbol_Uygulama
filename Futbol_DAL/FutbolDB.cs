using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol_Model;

namespace Futbol_DAL
{
    public class FutbolDB
    {
        
        public FutbolDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            Futbolcular = new Futbolcular(strConn);
            Takimlar = new Takimlar(strConn);
            Mevkiler = new Mevkiler(strConn);
            FutbolcularMevkiler = new FutbolcularMevkiler(strConn);
            
        }
        public Futbolcular Futbolcular { get; set; }
        public Takimlar Takimlar { get; set; }
        public Mevkiler Mevkiler { get; set; }
        public FutbolcularMevkiler FutbolcularMevkiler { get; set; }
    }
}
