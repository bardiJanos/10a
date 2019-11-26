using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        //első verzió 50 csillagot ír ki
        public static void HanyCsillag()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("*");
            }
        }
    

        public static void HanyCsillag(int hanycsillag,Boolean melle,string mit)
        {
            for (int i = 0; i < hanycsillag; i++)
            {
                if (melle)
                {
                    Console.Write(mit+" ");
                } else
                {
                    Console.WriteLine(mit);
                }
                
            }
            Console.WriteLine();
        }

        //függvény visszatérési értékkel
        public static int Negyzet(int szam)
        {
            return szam * szam;
        }
        //Készítsen egy olyan függvényt, amely
        //egy adott számot emel tetszőleges hatványra
        //Math.Pow(3,3)


        static void Main(string[] args)
        {
            //Írjon ki 15 csillagot egymás mellé!
            Console.WriteLine("***************");
            //Ez csak arra jó, amikor egymás mellé
            //kell pontosan 15 csillag

            //Írjon ki 15 csillagot egymás alá!
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
            //...
            //Mi van, ha 719 csillagot kell egymás alá írni?

            //jobb megoldás a ciklus
            for (int i = 0; i < 719; i++)
            {
                Console.WriteLine("*");
            }

            //megint kell 233 db
            for (int i = 0; i < 233; i++)
            {
                Console.Write("*");
            }
            //Ugyanazt csináljuk, csak más adatokkal

            //Vajon nem lehet ezt általánosítani? De :)
            //A megoldás az alprogram, vagy más néven függvény 
            //alkalmazása
            Console.WriteLine();
            HanyCsillag(5, false, "Hello");
            HanyCsillag(10, true, "Vaze");
            HanyCsillag(5, false, "Alprogram!");
            HanyCsillag(12, false, "Függvény!");

            //Visszatérési értékkel rendelkező függvény hívása
            int negyzet = Negyzet(9);
            Console.WriteLine(negyzet);
            Console.WriteLine(Negyzet(3));

            int[] sz1 = { 1, 8, 77, 9981, 65, 311, 989 };
            int[] sz2 = { 8, 78, 981, 6553, 31, 726 };

            Console.WriteLine();
            TombLista(sz1);
            Console.WriteLine();
            TombLista(sz2);

            Console.ReadKey();
        }

        private static void TombLista(int[] sz1)
        {
            for (int i = 0; i < sz1.Length; i++)
            {
                Console.Write(sz1[i]+" ");
            }
        }

        //Ide is kerülhet a függvény
    }
}
