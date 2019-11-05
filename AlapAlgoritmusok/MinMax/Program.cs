using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Minimum és maximum meghatározás
            int[] szamok = new int[] {18,3,79,66,945,411 };
            //olyan kezdőértéket állítunk be, aminél biztosan lesz
            //nagyobb
            int max = Int32.MinValue;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]>max)
                {
                    max = szamok[i];
                }
            }

            Console.WriteLine($"A maximum:{max}");
            Console.WriteLine($"Ellenőrzés:{szamok.Max()}");

            Console.ReadKey();
        }
    }
}
