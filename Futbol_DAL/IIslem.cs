using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_DAL
{
    public interface IIslem<T> where T:class
    {
        List<T> Liste();

        void Ekle(T model);

        void Sil(int id);

        void Guncelle(T model);

        T Bul(int id);
    }
}
