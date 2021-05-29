using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DalOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre) //kayıt sayısı döndürmesi için static
        {
            SqlCommand komut1 = new SqlCommand("insert into Ogrenci (OgrenciAdi,OgrenciSoyadi,OgrenciMail,OgrenciSifre,OgrenciNumara) values (@p1,@p2,@p3,@p4,@p5)", Connection.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ogrenciadi);
            komut1.Parameters.AddWithValue("@p2", parametre.Ogrencisoyadi);
            komut1.Parameters.AddWithValue("@p3", parametre.Mail);
            komut1.Parameters.AddWithValue("@p4", parametre.Sifre);
            komut1.Parameters.AddWithValue("@p5", parametre.Numara);
            return komut1.ExecuteNonQuery();
        }
           
    }
}
