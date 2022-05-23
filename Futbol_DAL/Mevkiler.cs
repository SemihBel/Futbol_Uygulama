using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol_Model;

namespace Futbol_DAL
{
    public class Mevkiler : IIslem<Mevki>
    {
        SqlConnection Conn;
        public Mevkiler(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public Mevki Bul(int id)
        {
            Conn.Open();
            Mevki mevki = new Mevki();
            SqlCommand command = new SqlCommand("select*from Mevkiler where MevkiID=@ID", Conn);
            command.Parameters.AddWithValue("@ID", id);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            mevki.MevkiID = -1;
            if (dataReader.HasRows)
            {
                mevki.MevkiID = dataReader.GetInt32(0);
                mevki.MevkiAd = dataReader.GetString(1);
            }
            Conn.Close();
            return mevki;
        }

        public void Ekle(Mevki model)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("insert into Mevkiler values(@ad)",Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ad", model.MevkiAd);

            command.ExecuteNonQuery();

            Conn.Close();
        }

        public void Guncelle(Mevki model)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("update Mevkiler set MevkiAd=@ad where" +
                "MevkiID=@ID", Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID",model.MevkiID);
            command.Parameters.AddWithValue("@ad", model.MevkiAd);

            command.ExecuteNonQuery();

            Conn.Close();
        }

        public List<Mevki> Liste()
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("select * from Mevkiler",Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            List<Mevki> mevkiler = new List<Mevki>();
            while (dataReader.Read())
            {
                Mevki mevki = new Mevki();

                mevki.MevkiID = dataReader.GetInt32(0);
                mevki.MevkiAd = dataReader.GetString(1);

                mevkiler.Add(mevki);
            }
            Conn.Close();
            return mevkiler;
        }

        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("delete from Mevkiler where MevkiID=@ID", Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", id);

            command.ExecuteNonQuery();

            Conn.Close();
        }
    }
}
