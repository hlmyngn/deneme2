using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gural.Staj.Egitim.MySql.DAL
{
    public class NotBL
    {
        public static bool NotEkle(Not not)
        {
            bool eklendi = false;
            MySqlConnection connection = null;
            try
            {
                string connectionString = "SERVER=localhost;DATABASE=OgrenciYonetimSistemi; UID=root;PASSWORD=hy050491;";

                connection = new MySqlConnection(connectionString);

                connection.Open();

                string query = "INSERT INTO notlar (Vize1, Vize2, Final) VALUES ('" + not.Vize1+ "','"+not.Vize2+"','"+not.Final+"')";

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

    }
}
