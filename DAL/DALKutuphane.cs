using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DAL
{
   public class DALKutuphane
    {
        public static object dataSet;

        public static List<kitaplar> Personellistesi()
        {
            List<kitaplar> deger = new List<kitaplar>();
            SqlCommand komut1 = new SqlCommand("Select * from kitaplar", DAL.con);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter();
            while (dr.Read())
            {

                kitaplar ent = new kitaplar();

               
                ent.k_id = int.Parse(dr["k_id"].ToString());
                ent.k_ad = dr["k_ad"].ToString();
                ent.k_kategori = int.Parse(dr["k_kategori"].ToString());
                ent.k_yazar = dr["k_yazar"].ToString();
                ent.k_durum = dr["k_durum"].ToString();

                //using (var memoryStream = new MemoryStream())
                //{
                //    BinaryFormatter bfWrite = new BinaryFormatter();
                //    bfWrite.Serialize(memoryStream, dr["k_resim"]);
                //    ent.k_resim = memoryStream.ToArray();
                //}

                ent.k_ozet = dr["k_ozet"].ToString();
                ent.k_sayfa = int.Parse(dr["k_sayfa"].ToString());
                
                deger.Add(ent);
            }
            dr.Close();
            return deger;
        }
        public static int personelekle(kitaplar n)
        {
            SqlCommand komut2 = new SqlCommand("Insert into kitaplar(k_ad,k_kategori,k_yazar,k_durum,k_resim,k_ozet,k_sayfa) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", DAL.con);
            if (komut2.Connection.State != System.Data.ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", n.k_ad);
            komut2.Parameters.AddWithValue("@p2", n.k_kategori);
            komut2.Parameters.AddWithValue("@p3", n.k_yazar);
            komut2.Parameters.AddWithValue("@p4", n.k_durum);
            komut2.Parameters.AddWithValue("@p5", n.k_resim);
            komut2.Parameters.AddWithValue("@p6", n.k_ozet);
            komut2.Parameters.AddWithValue("@p7", n.k_sayfa);
            return komut2.ExecuteNonQuery();
        }
        public static bool personelguncelle(kitaplar n)
        {
            SqlCommand komut4 = new SqlCommand("update kitaplar set k_ad=@p2,k_kategori=@p3,k_yazar=@p4,k_durum=@p5,k_ozet=@p7,k_sayfa=@p8   WHERE k_id=@p1", DAL.con);
            if (komut4.Connection.State != System.Data.ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", n.k_id );
            komut4.Parameters.AddWithValue("@p2", n.k_ad);
            komut4.Parameters.AddWithValue("@p3", n.k_kategori);
            komut4.Parameters.AddWithValue("@p4", n.k_yazar);
            komut4.Parameters.AddWithValue("@p5", n.k_durum);
            //komut4.Parameters.AddWithValue("@p6", n.k_resim);
            komut4.Parameters.AddWithValue("@p7", n.k_ozet);
            komut4.Parameters.AddWithValue("@p8", n.k_sayfa);
            return komut4.ExecuteNonQuery() > 0;
        }
        public static bool personelsil(int p)
        {
            SqlCommand komut3 = new SqlCommand("delete from kitaplar where k_id=@p1", DAL.con);
            if (komut3.Connection.State != System.Data.ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
    }
}
