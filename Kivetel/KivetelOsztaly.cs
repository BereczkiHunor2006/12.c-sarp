using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class KivetelOsztaly
    {
        public KivetelOsztaly() { }
        // Nincs kivétel kezelés
        public void KivKezNincs()
        {
            Console.WriteLine("Nincs Kivétel Kezelés\nAdjon meg egy karaktert!");
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            

          
        }
        public void KivKezAlt()
        {
            Console.WriteLine("\nHiba objektum nélküli kivétel kezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
                if (szam == 0)
                {
                    throw new ArgumentException("A beírt szám nem lehet nulla.");
                }
            }
            catch
            {
                Console.WriteLine("Hibás adat!");
            }
        }
        public void KivKezOs()
        {
            Console.WriteLine("\nŐs Hiba objektummal kivétel kezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A beírt szám: {szam}");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
