using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogTipusaOOP
{
    class HTipus
    {
        private int a, b, c;
        public HTipus(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool ErvenyesHaromszog()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
        public bool DerekszoguHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            int[] oldalak = {a, b, c};
            Array.Sort(oldalak);
            return (oldalak[0] * oldalak[0] + oldalak[1] * oldalak[1] == oldalak[2] * oldalak[2]);
        }
        public bool EgyenloszaruHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            return (a == b) || (a == c) || (b == c);
        }
        public bool EgyenloOldaluHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            return (a == b) && (b == c);
        }
        public double Terulet()
        {
            if (!ErvenyesHaromszog()) throw new InvalidOperationException("Nem érvényes háromszög");
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        static void Main(string[] args)
        {
            HTipus haromszog1 = new HTipus(3, 4, 5);
            Console.WriteLine($"Érvényes Háromszög: {haromszog1.ErvenyesHaromszog()}");
            Console.WriteLine($"Érvényes Háromszög: {haromszog1.DerekszoguHaromszog()}");
            Console.WriteLine($"Érvényes Háromszög: {haromszog1.EgyenloszaruHaromszog()}");
            Console.WriteLine($"Érvényes Háromszög: {haromszog1.EgyenloOldaluHaromszog()}");
            Console.WriteLine($"Terület: {haromszog1.Terulet()}");

            HTipus haromszog2 = new HTipus(5,5,5);
            Console.WriteLine($"Érvényes Háromszög: {haromszog2.ErvenyesHaromszog()}");
            Console.WriteLine($"Érvényes Háromszög: {haromszog2.DerekszoguHaromszog()}");
            Console.WriteLine($"Érvényes Háromszög: {haromszog2.EgyenloszaruHaromszog()}");
            Console.WriteLine($"Érvényes Háromszög: {haromszog2.EgyenloOldaluHaromszog()}");
            Console.WriteLine($"Terület: {haromszog2.Terulet()}");

            Console.ReadLine();
        }
    }
}
