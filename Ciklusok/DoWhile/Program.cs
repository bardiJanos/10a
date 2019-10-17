using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;

            do //csináld
            {
                Console.Clear();
                if (Console.KeyAvailable)
                {
                    szam = 0;
                    Console.ReadKey(false);
                } else
                {
                    szam++;
                }
                
                Console.WriteLine($"Számláló állása:{szam}");
                Thread.Sleep(500);


            } while (szam<30); //amíg szam kisebb mint 30

            //Házi feladat ennek a ciklusnak a lerajzolása
            //folyamatábrával

            //egészítsük ki a ciklust azzal, hogy egy gomb
            //lenyomására a számláló nullázódjon ki!
            Console.ReadKey();
        }
    }
}
