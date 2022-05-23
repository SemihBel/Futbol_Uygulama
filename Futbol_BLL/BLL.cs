using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol_DAL;
using Futbol_Model;

namespace Futbol_BLL
{
    public class BLL
    {
        FutbolDB db;
        public BLL()
        {
            db = new FutbolDB();
        }
        public List<Futbolcu> TumFutbolcular()
        {
            return db.Futbolcular.Liste();
        }
        public List<Futbolcu> TakimaAitFutbolcular(int takimID)
        {
            return db.Futbolcular.Liste().Where(x => x.TakimID == takimID).ToList();
        }
     
        public void Ekle(Futbolcu model)
        {
            db.Futbolcular.Ekle(model);
        }
        public void Sil(int id)
        {
            db.Futbolcular.Sil(id);
        }
        public void Guncelle(Futbolcu model)
        {
            db.Futbolcular.Guncelle(model);
        }

        public void TakimEkle(Takim model)
        {
            db.Takimlar.Ekle(model);
        }
        public void TakimSil(int id)
        {
            db.Takimlar.Sil(id);
        }
        public void TakimGuncelle(Takim model)
        {
            db.Takimlar.Guncelle(model);
        }



        //Takımlar
        public List<Takim> TumTakımlar() 
        {
            return db.Takimlar.Liste();
        }

      

        //Mevkiler
        public List<Mevki> TumMevkiler()
        {
            return db.Mevkiler.Liste();
        }

        //FutbolcularMevkiler
        public List<FutbolcuMevki> TumFutbolcularınMevkileri()
        {
            return db.FutbolcularMevkiler.Liste();
        }

    }
}
