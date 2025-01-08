using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyszog
{
    public class NegyszogClass
    {
        //Alakok meghatározása
        public double Oldalhossz { get; set; }
        public double Szelesseg { get; set; }

        public double terulet;
        public double kerulet;

        //1.konstruktor
        public NegyszogClass()
        {
            Oldalhossz = 0;
            Szelesseg = 0;
            terulet = 0;
            kerulet = 0;
        }
        //2.konstruktor
        public NegyszogClass(double oldalhossz)
        {
            Oldalhossz = oldalhossz;
            Szelesseg = oldalhossz;
            SetTerulet();
            SetKerulet();
        }
        //3.konstruktor
        public NegyszogClass(double oldalhossz, double szelesseg)
        {
            Oldalhossz = oldalhossz;
            Szelesseg = szelesseg;
            SetTerulet();
            SetKerulet();
        }

        //SetOldal1.
        public void SetOldal1(double a)
        {
            Oldalhossz = a;
            Szelesseg = a;
            SetTerulet();
            SetKerulet();
        }
        //SetOldal2.
        public void SetOldal2(double a, double b)
        {
            Oldalhossz = a;
            Szelesseg = b;
            SetTerulet();
            SetKerulet();
        }
        //SetTerulet
        public void SetTerulet()
        {
            terulet = Oldalhossz * Szelesseg;
        }
        public void SetKerulet()
        {
            kerulet = 2 * (Oldalhossz + Szelesseg);
        }
        public double GetTerulet()
        {
            return terulet;
        }
        public double GetKerulet()
        {
            return kerulet;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NegyszogClass negyszog1 = new NegyszogClass();
            Console.WriteLine($"Az alapértelmezett terület: {negyszog1.GetTerulet()}, az alapértelmezett kerület: {negyszog1.GetKerulet()}");

            NegyszogClass negyszog2 = new NegyszogClass(5);
            Console.WriteLine($"Az négyzet terület: {negyszog2.GetTerulet()}, a négyzet kerület: {negyszog2.GetKerulet()}");

            NegyszogClass negyszog3 = new NegyszogClass(4,6);
            Console.WriteLine($"A téglalap terület: {negyszog3.GetTerulet()}, a téglalap kerület: {negyszog3.GetKerulet()}");

            negyszog1.SetOldal1(3);
            Console.WriteLine($"Négyzet új területe: {negyszog1.GetTerulet()}, kerülete: {negyszog1.GetKerulet()}");

            // SetOldal2 metódus használata
            negyszog3.SetOldal2(5, 7);
            Console.WriteLine($"Téglalap új területe: {negyszog3.GetTerulet()}, kerülete: {negyszog3.GetKerulet()}");
        }
    }
}
