using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    class teglatest : tegla
    {
        private double terfogat, c, felszin;
        public teglatest(double n, double m, double ca)
        {
            this.a = m;
            this.b = n;
            this.c = ca;
            SetTerulet();
            this.felszin = 2 * (a * b + a * c + b * c);
            this.terfogat = a * b * c;
        }
        public double GetFelszin() { return this.felszin; }
        public double GetTerfogat() { return this.terfogat; }
    }
}
