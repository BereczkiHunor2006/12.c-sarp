using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    class tegla
    {
        private double a, b, kerulet, terulet;
        public tegla() { }
        public tegla(double m)
        {
            this.a = m;
        }
        // Metódusok
        public void ReadMeter(double m)
        {
            this.a = m;
        }
        public void ReadMeter2(double n)
        {
            this.b = n;
        }

        public void SetKerulet()
        {
            this.kerulet = 2 * (a + b);
        }
        public void SetTerulet()
        {
            this.terulet = a * b;
        }
        public double GetKerulet() { return this.kerulet; }
        public double GetTerulet() { return this.terulet; }
        public double GetMeter() { return this.a; }
        public double GetMeter2() { return this.b; }
    }
}
