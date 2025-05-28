using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace DBConnection
{
    public class DBConnectionClass
    {
        public static string GetConnectionString_2(string connectionName)
        {
            // string connectionName: A konfigurációs fájlban szereplő connection string neve, amelyet kulcsként használunk.
            try
            {
                // Az App.config fájlban lévő <connectionStrings> szekcióból próbálja kiolvasni a connectionName nevű kapcsolatot.
                string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

                return connectionString;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
                return "";
            }
        }
        public static string GetConnectionString_1()
        {
            /*
             * A metódus dinamikusan épít fel egy SQL Server kapcsolat karakterláncot (connection string) a konfigurációs állományból (App.config) beolvasott értékek alapján, majd visszaadja azt.
             */
            MySqlConnectionStringBuilder cnstrBuilder = new MySqlConnectionStringBuilder();
            cnstrBuilder.Server = ConfigurationManager.AppSettings["server"];
            cnstrBuilder.Database = ConfigurationManager.AppSettings["Database"];
            cnstrBuilder.UserID = ConfigurationManager.AppSettings["user"];
            cnstrBuilder.Password = ConfigurationManager.AppSettings["password"];

            cnstrBuilder.IntegratedSecurity = true;
            /*
             * Az 'IntegratedSecurity = true' azt jelenti, hogy Windows-hitelesítést használ a kapcsolat - tehát nem kell felhasználónév és jelszó az adatbázishoz való kapcsolódáshoz.
             * Tehát, a 'UserID' és a 'Password' sorok feleslegesek ebben az esetben, mert az 'IntegratedSecurity = true' azokat figyelmen kívül hagyja. Az 'IntegratedSecurity = false' esetben viszont szükséges.
             */
            cnstrBuilder.ConnectionTimeout = 30; // 30 másodpercre időkorlátot állít be a kapcsolódásra az SQL szerverhez.



            // A kapcsolat objektumot csak azért hozza létre, hogy belőle visszaadja a connection stringet.
            // A kapcsolat nem kerül megnyitásra, tehát nem történik hálózati művelet!
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = cnstrBuilder.ConnectionString;

            return cn.ConnectionString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}