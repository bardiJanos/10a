using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileCiklus
{
    class Program
    {
        static void Main(string[] args)
        {
            //elöltesztelő ciklus
            //belépési feltétele van, ha ez teljesül, akkor
            //végrehajtódik a ciklus, egyébként nem
            int szam = 1;

            while (szam<=30)
            {
                
                if (szam==10)
                {
                    //kilépés a ciklusból
                    break;
                }
                Console.WriteLine(szam);
                szam++;
            }

            //ciklus amíg le nem nyomnak egy adott billentyűt
            while (!Console.KeyAvailable || Console.ReadKey().Key!=ConsoleKey.Escape)
            {
                Console.WriteLine("Csak futok és futok");
            }

            //Házi feladat:az 1 példa felrajzolása folyamatábrával

            Console.ReadKey();
        }
    }
}
