using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Objektum
            tegla t1 = new tegla();
            t1.ReadMeter(15.8);
            t1.ReadMeter2(63.2);
            t1.SetKerulet();
            t1.SetTerulet();
            Console.WriteLine($"A {t1.GetMeter()} és {t1.GetMeter2()} méretű téglalapnak a kerülete: {t1.GetKerulet()}, és területe: {t1.GetTerulet()}");
            #endregion EOf 1.objektum
            #region 2.Objektum
            tegla t2 = new tegla();
            t2.ReadMeter(128.1);
            t2.ReadMeter2(57.5);
            t2.SetKerulet();
            t2.SetTerulet();
            Console.WriteLine($"A {t2.GetMeter()} és {t2.GetMeter2()} méretű téglalapnak a kerülete: {t2.GetKerulet()}, és területe: {t2.GetTerulet()}");
            #endregion EOf 2.objektum
            #region 3.Objektum
            tegla t3 = new tegla();
            t3.ReadMeter(5748.4);
            t3.ReadMeter2(371.7);
            t3.SetKerulet();
            t3.SetTerulet();
            Console.WriteLine($"A {t3.GetMeter()} és {t3.GetMeter2()} méretű téglalapnak a kerülete: {t3.GetKerulet()}, és területe: {t3.GetTerulet()}");
            #endregion EOf 3.objektum
            Console.ReadKey();
        }
    }
}