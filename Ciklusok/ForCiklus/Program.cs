using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCiklus
{
    class Program
    {
        static void Main(string[] args)
        {
            //írjunk ki egy szöveget pl.30X
            for (int i = 1; i <= 30; i++)
            {
                //ciklusmag
                Console.WriteLine($"ciklusváltozó:{i}");
            }

            //számoljon a ciklus visszafelé!!
            for(int i=30;i>=0; i--)
            {
                Console.WriteLine(i);
            }

            //számokat tartalmazó tömb
            int[] szamok = new int[] {11,2,3,29,6,5,19,38,99,121,686,718};

            //hivatkozás egy elemre
            Console.WriteLine(szamok[1]);
            Console.Clear();

            //egy tömb elemeinek kiíratása
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            //ebben a ciklusban nem lehet módosítani
            //a tömb elemeit!
            foreach (var n in szamok)
            {
                Console.WriteLine(n);
            }

            //Házi feladat
            //az 1. példa lerajzolása folyamatábrával

            Console.ReadKey();
        }
    }
}
