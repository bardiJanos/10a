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
            int a = -12;
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

            Console.ReadKey();
        }
    }
}
