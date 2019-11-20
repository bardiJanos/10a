using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veletlenek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írjon programot, amely létrehoz egy
            //véletlen elemszámú (50 és 100 közötti)
            //listát, és -100 és 200 közötti értékeket
            //rak bele
            //Írja ki a program az elemszámot és az elemeket!
            List<int> vszamok = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < rand.Next(50,101); i++)
            {
                vszamok.Add(rand.Next(-100, 201));
            }

            foreach (var i in vszamok)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(vszamok.Count);

           

            Console.ReadKey();
        }
    }
}
