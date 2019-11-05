using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlapAlgoritmusok
{
    class Program
    {
        static void Main(string[] args)
        {
            //tömb létrehozása
            int[] szamok = new int[] {1,211,56,97,445,19,49,76 };
            //ez a változó gyűjti az összeget
            int osszeg = 0;
            //ebbe a változóba darabszámot gyűjtünk
            int darab = 0;
            
            //ciklus, ami annyiszor fut le, ahány elem van a tömbben
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg = osszeg + szamok[i];
                darab = darab + 1;
            }

            Console.WriteLine($"Összeg:{osszeg},darabszám:{darab}");

            Console.ReadKey();

        }
    }
}
