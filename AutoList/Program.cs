using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoList
{
    public class Auto
    {
        // Osztály adattagjai
        public string Rendszam { get; set; }
        public string Gyartmany { get; set; }
        public string Tipus { get; set; }
        public int GyartasiEv { get; set; }
        public DateTime MuszakiVizsga { get; set; }
        public string TulajdonosNev { get; set; }

        // Konstruktor
        public Auto(string rendszam, string gyartmany, string tipus, int gyartasiEv, DateTime muszakiVizsga, string tulajdonosNev)
        {
            Rendszam = rendszam;
            Gyartmany = gyartmany;
            Tipus = tipus;
            GyartasiEv = gyartasiEv;
            MuszakiVizsga = muszakiVizsga;
            TulajdonosNev = tulajdonosNev;
        }
    }

    public class AutoList
    {
        private List<Auto> autok = new List<Auto>();

        // Beolvasás metódus
        public void Beolvas()
        {
            Console.Write("Kérem a fájl nevét: ");
            string fileName = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] adatok = line.Split(';');
                        if (adatok.Length == 6)
                        {
                            string rendszam = adatok[0];
                            string gyartmany = adatok[1];
                            string tipus = adatok[2];
                            int gyartasiEv = int.Parse(adatok[3]);
                            DateTime muszakiVizsga = DateTime.Parse(adatok[4]);
                            string tulajdonosNev = adatok[5];

                            Auto auto = new Auto(rendszam, gyartmany, tipus, gyartasiEv, muszakiVizsga, tulajdonosNev);
                            autok.Add(auto);
                        }
                    }
                }
                Console.WriteLine("A beolvasás befejeződött.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba történt: {e.Message}");
            }
        }

        // Kiir metódus
        public void Kiir()
        {
            Console.WriteLine("Rendszám\tGyártmány\tTípus\tGyártási év\tMűszaki vizsga\tTulajdonos neve");
            Console.WriteLine("--------------------------------------------------------------------------------");
            foreach (var auto in autok)
            {
                Console.WriteLine($"{auto.Rendszam}\t{auto.Gyartmany}\t{auto.Tipus}\t{auto.GyartasiEv}\t{auto.MuszakiVizsga.ToShortDateString()}\t{auto.TulajdonosNev}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AutoList autoList = new AutoList();

            autoList.Beolvas();

            autoList.Kiir();
            Console.ReadKey();
        }
    }
}
