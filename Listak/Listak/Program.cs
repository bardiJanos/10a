using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listák (dinamikus tömb)
            //Deklarálás
            List<int> szamok = new List<int>();

            //elem hozzádása 
            szamok.Add(122);
            szamok.Add(212);
            szamok.Add(33);

            //a lista elemeinek a száma: Count
            Console.WriteLine(szamok.Count);

            //a lista elemeinek kiírása 
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok[i]);
            }
            //A count-ot leszámítva ugyanaz, mint a tömb kiíratása

            //Könnyen megállapítható, hogy egy elem
            //rajta van-e a listán
            //Ha az IndexOf -1 et ad, akkor nincsen
            Console.WriteLine(szamok.IndexOf(299));

            if (szamok.IndexOf(299)==-1)
            {
                Console.WriteLine("Ez nincs a listán");
            }

            


            Console.ReadKey();
        }
    }
}
