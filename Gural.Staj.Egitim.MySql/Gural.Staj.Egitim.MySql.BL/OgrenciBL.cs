using Gural.Staj.Egitim.MySql.DAL;
using Gural.Staj.Egitim.MySql.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gural.Staj.Egitim.MySql.BL
{
    public class OgrenciBL
    {
        public static bool OgrenciEkle(Ogrenci ogrenci)
        {
            bool eklendi = false;
            MySqlConnection connection = null;
            try
            {
                string connectionString = "SERVER=localhost;DATABASE=OgrenciYonetimSistemi; UID=root;PASSWORD=hy050491;";

                connection = new MySqlConnection(connectionString);

                connection.Open();

                string query = "INSERT INTO ogrenci (Adi, Soyadi) VALUES('" + ogrenci.Adi + "', '" + ogrenci.Soyadi + "')";

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                int sonucDeger = cmd.ExecuteNonQuery();
                if (sonucDeger > 0)
                    eklendi = true;
        }
            catch (Exception ex)
            {
                eklendi = false;
            }
            finally
            {
                connection.Close();
            }
            return eklendi;
        }

        public static bool OgrenciGuncelle(Ogrenci ogrenci)
        {
            bool eklendi = false;
            MySqlConnection connection = null;
            try
            {
                string connectionString = "SERVER=localhost;DATABASE=OgrenciYonetimSistemi; UID=root;PASSWORD=hy050491;";

                connection = new MySqlConnection(connectionString);

                connection.Open();

                //string query2 = "UPDATE Ogrenci SET id = '" + ogrenci.Id + "' WHERE numbers = '" + ogrenci.Adi + "','" + ogrenci.Soyadi+ "'";

                string query = "UPDATE Ogrenci o SET o.Adi='" + ogrenci.Adi+"',o.Soyadi='"+ogrenci.Soyadi + "' WHERE o.Id='"+ogrenci.Id+"'";

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                int sonucDeger = cmd.ExecuteNonQuery();
                if (sonucDeger > 0)
                    eklendi = true;

            }
            catch (Exception ex)
            {
                eklendi = false;
            }
            finally
            {
                connection.Close();
            }
            return eklendi;
        }
        
        public static bool OgrenciSil(Ogrenci ogrenci)
        {
            bool eklendi = false;
            MySqlConnection connection = null;
            try
            {
                string connectionString = "SERVER=localhost;DATABASE=OgrenciYonetimSistemi; UID=root;PASSWORD=hy050491;";

                connection = new MySqlConnection(connectionString);

                connection.Open();
                string query = "DELETE FROM Ogrenci WHERE Id='" + ogrenci.Id + "'";

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                int sonucDeger = cmd.ExecuteNonQuery();
                if (sonucDeger > 0)
                    eklendi = true;

            }
            catch (Exception ex)
            {
                eklendi = false;
            }
            finally
            {
                connection.Close();
            }
            return eklendi;
        }

        public static List<Ogrenci> OgrencileriGetir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            MySqlConnection connection=null;
            try
            {
                string connectionString="SERVER=localhost;DATABASE=OgrenciYonetimSistemi; UID=root;PASSWORD=hy050491;";
                 connection = new MySqlConnection(connectionString);
                
                connection.Open();
                string query = "SELECT * FROM Ogrenci";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader= cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Id=Convert.ToInt32(reader["Id"]);
                    ogrenci.Adi=reader["Adi"].ToString();
                    ogrenci.Soyadi = reader["Soyadi"].ToString();

                    ogrenciler.Add(ogrenci);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ogrenciler;
        }

        public static bool OgrenciDersEkle(OgrenciDersleri secilenDers)
        {
            bool eklendi = false;
            MySqlConnection connection = null;
            try
            {
                string connectionString = "SERVER=localhost;DATABASE=OgrenciYonetimSistemi; UID=root;PASSWORD=hy050491;";

                connection = new MySqlConnection(connectionString);

                connection.Open();

                string query = " INSERT INTO ogrencidersleri (Ogrenci,Ders) VALUES('" + secilenDers.Ogrenci.Id + "','" + secilenDers.Ders.Id + "')";
            
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                int sonucDeger = cmd.ExecuteNonQuery();
                if (sonucDeger > 0)
                    eklendi = true;
            }
            catch (Exception ex)
            {
                eklendi = false;
            }
            finally
            {
                connection.Close();
            }
            return eklendi;
        }
       
        public static List<OgrenciDersleri> OgrenciDersGetir(Ogrenci ogrenci) { 
         List<OgrenciDersleri> ogrenciDersleri = new List<OgrenciDersleri>();
            MySqlConnection connection=null;
            try
            {
                string connectionString="SERVER=localhost;DATABASE=OgrenciYonetimSistemi; UID=root;PASSWORD=hy050491;";
                 connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM OgrenciDersleri";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader= cmd.ExecuteReader();

                while (reader.Read())
                {
                    OgrenciDersleri ogreciDers = new OgrenciDersleri();
                    ogreciDers.Id = Convert.ToInt32(reader["Id"]);

                    ogreciDers.Ogrenci = new Ogrenci();
                    ogreciDers.Ogrenci.Id = Convert.ToInt32(reader["Ogrenci"]);
                    ogreciDers.Ders = new Ders();
                    
                    ogreciDers.Ders.Id = Convert.ToInt32(reader["Ders"]);

                    string studentQuery = "SELECT * FROM Ogrenci WHERE Id = '" + ogreciDers.Ogrenci.Id + "'";

                    MySqlCommand cmdStudent = new MySqlCommand(query, connection);
                    MySqlDataReader readerStudent = cmd.ExecuteReader();
                    while (readerStudent.Read())
                    {
                        ogreciDers.Ogrenci.Adi = readerStudent["Adi"].ToString();
                        ogreciDers.Ogrenci.Soyadi = readerStudent["Soyadi"].ToString();
                    }
                    
                    ogrenciDersleri.Add(ogreciDers);
                }
                connection.Close();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    for (int i = 0; i < table.Rows.Count; i++)
                {
                    string adi = table.Rows[i]["Id"].ToString();
                }
                //DersBilgileriDoldur(ogrenciDersleri);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ogrenciDersleri;
        }
     
    }
}
