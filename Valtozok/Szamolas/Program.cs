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
            int a, b, c = 0;

            Console.Write("A:");

            //A Console.ReadLine() string típus olvas be!
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B:");
                        
            b = Convert.ToInt32(Console.ReadLine());

            //c értékének megadása
            c = a + b;

            Console.WriteLine($"C:{c}");

            Console.ReadKey();
        }
    }
}
