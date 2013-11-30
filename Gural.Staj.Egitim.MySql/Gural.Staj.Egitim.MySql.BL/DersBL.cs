using Gural.Staj.Egitim.MySql.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gural.Staj.Egitim.MySql.BL
{
   public class DersBL
    {
        public static bool DersEkle(Ders ders)
        {
            bool eklendi = false;
            MySqlConnection connection = null;
            try
            {
                string connectionString = "SERVER=localhost;DATABASE=OgrenciYonetimSistemi; UID=root;PASSWORD=hy050491;";

                connection = new MySqlConnection(connectionString);

                connection.Open();

                string query = "INSERT INTO ders (Adi) VALUES('" + ders.DersAdi + "')";

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
        public static List<Ders> DersGetir()
        {
            List<Ders> dersler = new List<Ders>();
            MySqlConnection connection = null;
            try
            {
                string connectionString = "SERVER=localhost;DATABASE=OgrenciYonetimSistemi; UID=root;PASSWORD=hy050491;";
                connection = new MySqlConnection(connectionString);

                connection.Open();
                string query = "SELECT * FROM Ders";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
               // DataTable table = new DataTable();
               // table.Load(reader);

               //for (int i = 0; i < table.Rows.Count; i++)
               // {
               //     string adi = table.Rows[i]["Adi"].ToString();
               // }

                while (reader.Read())
                {
                    Ders ders = new Ders();
                    ders.Id = (int)reader["Id"];
                    ders.DersAdi = reader["Adi"].ToString();
                    dersler.Add(ders);
                }
  
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dersler;
        }
    }
}
