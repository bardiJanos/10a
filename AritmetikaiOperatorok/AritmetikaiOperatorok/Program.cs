using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikaiOperatorok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Értéknövelő
            int a = 20;
            int b=a++;
            //Mennyi lesz b?
            Console.WriteLine(b);

            a = 25;
            b = ++a;
            //És most?

            a = a * 3;
            //ugyanaz
            a *= 3;

            a = a - 3;
            //ugyanaz
            a -= 3;

            Console.WriteLine(b);

            //logikai vagy(OR) művelet
            //ha bármelyik érték igaz, a kifejezés is igaz
            //
            Console.WriteLine(false || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);

            //logikai és művelet, csak akkor igaz, ha minden érték igaz

            Console.WriteLine(false && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);

            //maradékképzés
            //arra vagyunk kíváncsiak, hogy a művelet végrehajtása
            //során képződik e maradék

            Console.WriteLine(125%2);
            b = 125;

            if (b%2==0)
            {
                Console.WriteLine($"{b} osztható 2-vel!");
            }else
            {
                Console.WriteLine($"{b} nem osztható 2-vel!");
            }





            Console.ReadKey();
        }
    }
}
