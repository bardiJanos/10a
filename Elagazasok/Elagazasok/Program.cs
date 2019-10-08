using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elágazások
            //Egyszeres egyágú
            int a = 0;
            if (a>0)
            {
                Console.WriteLine("Pozitív szám");
            }

            //egyszeres, kétágú
            if (a>=0)
            {
                Console.WriteLine("Pozitív szám");
            }
            else
            {
                Console.WriteLine("Negatív szám");
            }

            //többszörös
            if (a>0)
            {
                Console.WriteLine("Pozitív szám");
            }
            else if (a==0)
            {
                Console.WriteLine("Nulla");
            }
            else
            {
                Console.WriteLine("Negatív szám");
            }

            a = 25;
            //
            if (a>10 && a<=20)
            {
                Console.WriteLine("10-nél nagyobb");
            }
            else if (a>20 && a<=30)
            {
                Console.WriteLine("20-nál nagyobb");
            }
            else if (a>30)
            {
                Console.WriteLine("30-nál nagyobb");
            }
            else
            {
                Console.WriteLine("Nem nagyobb mint 10");
            }


            Console.ReadKey();
        }
    }
}
