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
            int[] szamok = new int[100];

            //deklarálás a var kulcsszóval
            var szamok2 = new int[10];

            //deklarálás az elemek megadásával
            int[] szamok3 = {1,2,3,4,5};

            //tömbök indexelése
            szamok[0] = 121;

            //tömb feltöltése
            //Véletlen számok létrehozása
            Random rand = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {


                szamok[i] = rand.Next(-100,101);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Green;
                }

                if (szamok[i]>0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                
                Console.WriteLine($"{i}:{szamok[i]}");
                Console.ResetColor();
            }

            //tömb listázása elöltesztelő ciklussal
            var szamlalo = 0;
            while (szamlalo<szamok.Length)
            {
                //Console.WriteLine($"{szamlalo}:{szamok[szamlalo]}");
                szamlalo++;
            }
            //Visszafelé számoló for ciklus
            for (int i = szamok.Length-1; i>=0  ; i--)
            {
                //Console.WriteLine($"{i}:{szamok[i]}");
            }

            Console.ReadKey();
        }
    }
}
