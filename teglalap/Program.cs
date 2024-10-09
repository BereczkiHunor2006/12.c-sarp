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
            Console.ReadKey();
        }
    }
}