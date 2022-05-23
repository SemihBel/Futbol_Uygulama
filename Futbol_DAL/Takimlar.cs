using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol_Model;

namespace Futbol_DAL
{
    public class Takimlar : IIslem<Takim>
    {
        SqlConnection Conn;
        public Takimlar(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public Takim Bul(int id)
        {
            Conn.Open();
            Takim takim = new Takim();
            SqlCommand command = new SqlCommand("select*from Takimlar where TakimID=@ID", Conn);
            command.Parameters.AddWithValue("@ID", id);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            takim.TakimID = -1;
            if (dataReader.HasRows)
            {
                takim.TakimID = dataReader.GetInt32(0);
                takim.TakimAd = dataReader.GetString(1);                
                takim.TakimKupa = dataReader.GetByte(2);
                
            }
            Conn.Close();
            return takim;
        }

        public void Ekle(Takim model)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("insert into Takimlar values" +
                "(@ad,@kupaSayisi)",Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ad",model.TakimAd);           
            command.Parameters.AddWithValue("@kupaSayisi",model.TakimKupa);

            command.ExecuteNonQuery();

            Conn.Close();
        }

        public void Guncelle(Takim model)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("update Takimlar set TakimAd=@ad," +
                "TakimKupa=@kupa where TakimID=@ID",Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", model.TakimID);
            command.Parameters.AddWithValue("@ad", model.TakimAd);           
            command.Parameters.AddWithValue("@kupa", model.TakimKupa);

            command.ExecuteNonQuery();

            Conn.Close();
        }

        public List<Takim> Liste()
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("select*from Takimlar", Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            List<Takim> takimlar = new List<Takim>();
            while (dataReader.Read())
            {
                Takim takim = new Takim();

                takim.TakimID = dataReader.GetInt32(0);
                takim.TakimAd = dataReader.GetString(1);
                takim.TakimKupa = dataReader.GetByte(2);

                takimlar.Add(takim);
            }
            Conn.Close();
            return takimlar;

        }

        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("delete from Takimlar where TakimID=@ID", Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", id);

            command.ExecuteNonQuery();

            Conn.Close();
        }
    }
}
