using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaratList
{
    public class Barat
    {
        public string Nev { get; set; }
        public DateTime Szuldat { get; set; }
        public string Nem { get; set; }
        public int Bulihajlam { get; set; }

        public Barat(string nev, DateTime szuldat, string nem, int bulihajl)
        {
            Nev = nev;
            Szuldat = szuldat;
            Nem = nem;
            Bulihajlam = bulihajl;
        }
    }
    public class Baratlista
    {
        private List<Barat> baratok = new List<Barat>();

        public void Beolvaso()
        {
            Console.Write("Kérem a fájl nevét: ");
            string fajlneve = Convert.ToString(Console.ReadLine());

            try
            {
                using(StreamReader sr = new StreamReader(fajlneve))
                {
                    string sor;
                    while ((sor = sr.ReadLine()) != null)
                    {
                        string[] adatok = sor.Split(',');
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
