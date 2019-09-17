using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömb deklarálása
            //10 elemű, integer típusú számot tud tárolni.
            int[] szamok = new int[10];

            //deklarálás a var kulcsszóval
            var szamok2 = new int[10];

            //deklarálás az elemek megadásával
            int[] szamok3 = {1,2,3,4,5};

            //tömbök indexelése
            szamok[0] = 121;

            //tömb feltöltése
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = 222;
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            Console.ReadKey();
        }
    }
}
