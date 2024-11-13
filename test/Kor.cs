using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KorHasab
{
    class Kor
    {
        // Az osztály feladata a sugárból kiszámítja a kör területét és kerületét.

        // Osztályváltozók
        protected double sugar, terulet, kerulet;
        //Konstruktorok
        public Kor(){
        
        }
        public Kor(double r)
        {
            this.sugar = r;
        }
        // Metódusok
        public void ReadSugar(double r)
        {
            this.sugar = r;
        }

        public void SetKerulet()
        {
            this.kerulet = 2 * sugar * Math.PI;
        }
        public void SetTerulet()
        {
            double eredmeny = 0.0;
            double eredmeny_2 = 0.0;
            eredmeny = this.sugar * this.sugar * Math.PI;
            eredmeny_2 = Math.Pow(this.sugar, 2) * Math.PI;

            if (eredmeny==eredmeny_2)
            {
                this.terulet = eredmeny;
            }
            else
            {
                Console.WriteLine($"Eredmény ({eredmeny}) != Eredmény_2 ({eredmeny_2})");
            }
        }

        public double GetKerulet() { return this.kerulet; }
        public double GetTerulet() { return this.terulet; }
        public double GetSugar() { return this.sugar; }
    } 
}