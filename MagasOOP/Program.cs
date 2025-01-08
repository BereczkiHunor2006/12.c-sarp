using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagasOOP
{
    public class MagasOOP
    {
        //Megadjuk a tárgy alját.
        public double AlsoTav { get; set; }

        //Megadjuk a tárgy tetejét.
        public double TetoTav { get; set; }

        //Egy konstruktor, amely beállítja a magassághoz tartozó távolságokat.
        public MagasOOP(double alsotav, double tetotav)
        {
            AlsoTav = alsotav;
            TetoTav = tetotav;
        }

        // Egy metódus, amely kivonva a tetőt az aljból kiszámítja a tárgy magasságot.
        public double Magas()
        {
            return TetoTav - AlsoTav;
        }
        //Még egy metódus, amelyben kiírjuk a végeredményt.
        public void KiirMagassag()
        {
            Console.WriteLine($"A tárgy magassága: {Magas()} méter.");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {

            MagasOOP magas = new MagasOOP(100,200);
            magas.KiirMagassag();
            Console.ReadKey();
        }
    }
}
