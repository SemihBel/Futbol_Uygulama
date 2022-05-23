using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol_Model;

namespace Futbol_DAL
{
    public class FutbolcularMevkiler:IIslem<FutbolcuMevki>
    {
        SqlConnection Conn;
        public FutbolcularMevkiler(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public FutbolcuMevki Bul(int id)
        {
            Conn.Open();
            FutbolcuMevki futbolcuMevki = new FutbolcuMevki();
            SqlCommand command = new SqlCommand("select*from FutbolcularMevkiler where " +
                "FutbolcuMevkiID=@ID", Conn);
            command.Parameters.AddWithValue("@ID", id);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            futbolcuMevki.MevkiID = -1;
            if (dataReader.HasRows)
            {
                futbolcuMevki.FutbolcuMevkiID = dataReader.GetInt32(0);
                futbolcuMevki.MevkiID = Convert.ToInt32(dataReader["MevkiID"]);
                futbolcuMevki.FutbolcuID = Convert.ToInt32(dataReader["FutbolcuID"]);
            }
            Conn.Close();
            return futbolcuMevki;
        }

        public void Ekle(FutbolcuMevki model)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("insert into FutbolcularMevkiler values" +
                "(@mevkiID,@futbolcuID)",
                Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@mevkiID", model.MevkiID);
            command.Parameters.AddWithValue("@futbolcuID", model.FutbolcuID);

            command.ExecuteNonQuery();

            Conn.Close();
        }

        public void Guncelle(FutbolcuMevki model)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("update FutbolcularMevkiler set" +
                " MevkiID=@mevkiID,FutbolcuID=futbolcuID where" +
                "FutbolcuMevki=@ID", Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", model.FutbolcuMevkiID);
            command.Parameters.AddWithValue("@mevkiID", model.MevkiID);
            command.Parameters.AddWithValue("@futbolcuID", model.FutbolcuID);

            command.ExecuteNonQuery();

            Conn.Close();
        }

        public List<FutbolcuMevki> Liste()
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("Select * from FutbolcularMevkiler fm inner join" +
                " Futbolcular f on fm.FutbolcuID=f.FutbolcuID inner join Mevkiler m on fm.MevkiID=m.MevkiID",Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            List<FutbolcuMevki> futbolcuMevkiler = new List<FutbolcuMevki>();
            while (dataReader.Read())
            {
                FutbolcuMevki futbolcuMevki = new FutbolcuMevki();

                futbolcuMevki.FutbolcuMevkiID = dataReader.GetInt32(0);
                futbolcuMevki.MevkiID = Convert.ToInt32(dataReader["MevkiID"]);
                futbolcuMevki.FutbolcuID = Convert.ToInt32(dataReader["FutbolcuID"]);
                futbolcuMevki.FutbolcuAd = dataReader["FutbolcuAd"].ToString();
                futbolcuMevki.MevkiAd = dataReader["MevkiAd"].ToString();
                futbolcuMevkiler.Add(futbolcuMevki);
                
            }
            Conn.Close();
            return futbolcuMevkiler;
        }

        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("delete from FutbolcularMevkiler where" +
                " FutbolcuMevkiID=@ID", Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", id);

            command.ExecuteNonQuery();

            Conn.Close();
        }
    }
}
