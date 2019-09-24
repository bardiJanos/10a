using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErtekEsRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            a = 12;
            b = 24;
            b = a;
            a = 19;
            Console.WriteLine($"b értéke:{b}");

            //referencia típus
            string[] szovegek = {"egy","kettő","három" };

            string[] szovegek2 = {"négy","öt" };

            szovegek2[0] = "száz";

            Console.WriteLine($"Szovegek első eleme:{szovegek[0]}");






            Console.ReadKey();
        }
    }
}
