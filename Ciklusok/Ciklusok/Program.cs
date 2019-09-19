using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konzol
            Console.WriteLine($"Az ablak szélessége:{Console.WindowWidth}");
            Console.WriteLine($"Az ablak magassága:{Console.WindowHeight}");

            Console.SetCursorPosition(12, 12);
            Console.WriteLine("Mizu?");
            //Console törlése
            Random rand = new Random();
            Console.Clear();

            //Várakozás beiktatása
            Thread.Sleep(1000);

            //Kurzor eltüntetése
            Console.CursorVisible = false;

            //ciklus, amíg el nem érjük az ablak jobb oldalát
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                //ha a szöveg elérte az utolsó oszlopot
                //kilépünk a ciklusból, akkor is ha egyébként
                //még futna
                if ("Hell!O!".Length+i>Console.WindowWidth)
                {
                    break;
                }

                Console.Clear();
                Console.SetCursorPosition(i,10);
                Console.Write("Hell!O!");
                Thread.Sleep(100);
               
            }

            Console.WriteLine("Vége!");

            Console.ReadKey();
        }
    }
}
