using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Keresés a tömbben
            int[] szamok = new int[] {10,4,21,79,86,115,272,69};

            Console.Write("A keresett érték:");
            int keresett = Convert.ToInt32(Console.ReadLine());
            int pozicio = -1;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (keresett==szamok[i])
                {
                    pozicio = i;
                    Console.WriteLine($"A {keresett} érték a {pozicio}. indexű elem.");
                    break;
                } 
            }

            if (pozicio==-1)
            {
                Console.WriteLine($"A {keresett} érték nem található!");
            }

            Console.ReadKey();

        }
    }
}
