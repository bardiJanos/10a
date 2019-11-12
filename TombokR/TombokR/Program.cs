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

            //Hány százaléka negatív a tömb elemeinek?

            //Külön változóban gyűjtjük a negatív változók számát
            int negativDb = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<0)
                {
                    //ha a tömb eleme kisebb mint 0, akkor a negatív
                    //számok darabszámát tartalmazó változó értékét
                    //1-el növeljük
                    negativDb++;
                }
            }
            //Típuskényszerítés: megváltoztatom az eredmény típusát
            Console.WriteLine($"Negatív elemek aránya:{(double)negativDb/szamok.Length*100} %");

            //Határozzuk meg a pozitív elemek arányát, összegét, átlagát!


            Console.ReadKey();
        }
    }
}
