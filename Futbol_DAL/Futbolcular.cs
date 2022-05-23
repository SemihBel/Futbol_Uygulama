using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol_Model;


namespace Futbol_DAL

{
    public class Futbolcular : IIslem<Futbolcu>
    {
        SqlConnection Conn;
        public Futbolcular(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public Futbolcu Bul(int id)
        {
            Conn.Open();
            Futbolcu futbolcu = new Futbolcu();
            SqlCommand command = new SqlCommand("select*from Futbolcular where FutbolcuID=@ID",
                Conn);
            command.Parameters.AddWithValue("@ID", id);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            futbolcu.FutbolcuID = -1;
            if (dataReader.HasRows)
            {
                futbolcu.FutbolcuID = dataReader.GetInt32(0);
                futbolcu.FutbolcuAd = dataReader.GetString(1);
                futbolcu.FutbolcuSoyad = dataReader.GetString(2);
                futbolcu.FutbolcuYas = dataReader.GetByte(3);
                futbolcu.FutbolcuYetenek = dataReader.GetByte(4);
                futbolcu.FutbolcuDeger = dataReader.GetDecimal(5);
                futbolcu.TakimID = Convert.ToInt32(dataReader["TakimID"]);
               
            }
            Conn.Close();
            return futbolcu;
        }

        public void Ekle(Futbolcu model)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("insert into Futbolcular " +
                "values(@ad,@soyad,@yas,@yetenek,@deger,@takimID)", Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ad",model.FutbolcuAd);
            command.Parameters.AddWithValue("@soyad",model.FutbolcuSoyad);
            command.Parameters.AddWithValue("@yas",model.FutbolcuYas);
            command.Parameters.AddWithValue("@yetenek",model.FutbolcuYetenek);
            command.Parameters.AddWithValue("@deger",model.FutbolcuDeger);
            command.Parameters.AddWithValue("@takimID",model.TakimID);
            

            command.ExecuteNonQuery();

            Conn.Close();
        }

        public void Guncelle(Futbolcu model)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("update Futbolcular set FutbolcuAd=@ad," +
                "FutbolcuSoyad=@soyad,FutbolcuYas=@yas,FutbolcuYetenek=@yetenek," +
                "FutbolcuDeger=@deger,TakimID=@takimID where FutbolcuID=@ID"
                ,Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", model.FutbolcuID);
            command.Parameters.AddWithValue("@ad", model.FutbolcuAd);
            command.Parameters.AddWithValue("@soyad", model.FutbolcuSoyad);
            command.Parameters.AddWithValue("@yas", model.FutbolcuYas);
            command.Parameters.AddWithValue("@yetenek", model.FutbolcuYetenek);
            command.Parameters.AddWithValue("@deger", model.FutbolcuDeger);
            command.Parameters.AddWithValue("@takimID", model.TakimID);
            
            command.ExecuteNonQuery();
            
            Conn.Close();
        }

        public List<Futbolcu> Liste()
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("select*from Futbolcular", Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            List<Futbolcu> futbolcular = new List<Futbolcu>();
            while (dataReader.Read())
            {
                Futbolcu futbolcu = new Futbolcu();

                futbolcu.FutbolcuID = dataReader.GetInt32(0);
                futbolcu.FutbolcuAd=dataReader.GetString(1);
                futbolcu.FutbolcuSoyad = dataReader.GetString(2);
                futbolcu.FutbolcuYas = dataReader.GetByte(3);
                futbolcu.FutbolcuYetenek = dataReader.GetByte(4);
                futbolcu.FutbolcuDeger = dataReader.GetDecimal(5);
                futbolcu.TakimID = Convert.ToInt32(dataReader["TakimID"]);
                
                
                

                futbolcular.Add(futbolcu);

            }
            Conn.Close();
            return futbolcular;
        }

        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand("delete from Futbolcular where FutbolcuID=@ID",Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID",id);

            command.ExecuteNonQuery();

            Conn.Close();
        }
    }
}
