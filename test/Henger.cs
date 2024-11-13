using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Henger : Kor
    {
        //osztályváltozók
        private double magassag, terfogat;
        //konstruktor
        public Henger(double r, double m)
        {
            this.sugar = r;
            this.magassag = m;
            SetTerulet(); // Az eredmény a terület nevű osztályváltozóba kerül.
            this.terfogat = this.terulet * this.magassag;
        }

        public double GetTerfogat() { return this.terfogat; }
        public double GetMagassag() { return this.magassag; }
    }
}
