using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagasOOP
{
    public class Magassag
    {
        public double AlsoTav { get; set; }

        public double TetoTav { get; set; }

        public Magassag(double alsotav, double tetotav)
        {
            AlsoTav = alsotav;
            TetoTav = tetotav;
        }

        public double Magas()
        {
            return TetoTav - AlsoTav;
        }
        public void KiirMagassag()
        {
            Console.WriteLine($"A tárgy magassága: {Magas()} méter.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Magassag magas = new Magassag(Console.Write("Add meg az alját: "), Console.Write("Add meg a tetejét: ");
            magas.KiirMagassag();
            Console.ReadKey();

        }
    }
}

