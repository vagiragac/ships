using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14253001
//VELİ AĞIRAĞAÇ
namespace _14253001HW4

{
    class Program
    {
        static void Main(string[] args)
        {
            Gemi[] gdizi = new Gemi[3];
            gdizi[0] = new Gemi("Veli'nin gemisi", "10.04.2017");
            Console.WriteLine(gdizi[0].ToString());
            Console.WriteLine("\n");
            gdizi[1] = new TuristikGemi("Serhat'ın gemisi", "20.10.2017", 300);
            Console.WriteLine(gdizi[1].ToString());
            Console.WriteLine("\n");
            gdizi[2] = new KargoGemi("Fatma'nın gemisi", "20.10.2017", -50);
            Console.WriteLine(gdizi[2].ToString());
        }
    }
}
