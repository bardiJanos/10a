using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombokR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alap algoritmusok gyakorlása, véletlenszámok
            
            //200 elemű tömb létrehozása
            int[] szamok = new int[200];

            //Hogyan kéne feltölteni a tömböt véletlen számokkal?
            //Véletlen szám létrehozás
            Random rand = new Random();

            //Tömb feltöltése
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-100, 101);
            }

            //Tömb elemeinek kiíratása
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }


        }
    }
}
