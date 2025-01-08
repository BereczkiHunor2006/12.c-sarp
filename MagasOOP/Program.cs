using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagasOOP
{
    public class MagasOOP
    {
        public double AlsoTav { get; set; }

        public double TetoTav { get; set; }

        public MagasOOP(double alsotav, double tetotav)
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

            MagasOOP magas = new MagasOOP(100,200);
            magas.KiirMagassag();
            Console.ReadKey();
        }
    }
}
