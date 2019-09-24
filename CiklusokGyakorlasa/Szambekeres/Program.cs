using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szambekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.Write("A:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("B:");
            b = Convert.ToDouble(Console.ReadLine());

            //0 esetén újra be kell kérni, mert nem lehet 0-val osztani
            while (b==0)
            {
                Console.Write("Rossz!!B:");
                b = Convert.ToDouble(Console.ReadLine());
            }

            c = a / b;

            Console.WriteLine(c);


            Console.ReadKey();
        }
    }
}
