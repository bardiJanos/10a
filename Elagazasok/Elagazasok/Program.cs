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

            //írjon szelekciót, amely egy számról
            //megállapítja, hogy 1-es 10-es 100-as v. 1000-es
            //nagyságrendű-e!
            a = 10001;
            if (a<10)
            {
                Console.WriteLine("Egyes");
            }
            else if (a/10<10)
            {
                Console.WriteLine("tízes");
            }
            else if (a/100<10)
            {
                Console.WriteLine("százas");
            }
            else 
            {
                Console.WriteLine("ezres");
            }

            int b = 2;

            switch (b)
            {
                case 1:
                    Console.WriteLine("b értéke 1");
                    break;
                case 2:
                    Console.WriteLine("b most 2");
                    break;
                default:
                    Console.WriteLine("Alapeset");
                    break;
            }

            ConsoleKey bill = ConsoleKey.DownArrow;

            switch (bill)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("Up");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Down");
                    break;
                default:
                    Console.WriteLine(bill);
                    break;
            }



            Console.ReadKey();
        }
    }
}
