using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamolas
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c = 0;

            Console.Write("A:");

            //A Console.ReadLine() string típus olvas be!
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("B:");
                        
            b = Convert.ToDouble(Console.ReadLine());

            //c értékének megadása
            c = a / b;

            Console.WriteLine($"C:{c}");

            Console.ReadKey();
        }
    }
}
