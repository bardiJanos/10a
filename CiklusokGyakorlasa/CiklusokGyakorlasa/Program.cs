using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklusokGyakorlasa
{
    class Program
    {
        static void Main(string[] args)
        {
            //for ciklus
            //a 2 első 20 hatványát írjuk ki.
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Math.Pow(2,i));
            }

            //Készítsük el while-al ugyanezt!
            int hatvany = 8;
            while (hatvany<=40)
            {
                Console.WriteLine(Math.Pow(2, hatvany));
                hatvany++;
                //hatvany=hatvany+1; -ezt is írhattam volna

            }

            hatvany = 40;
            while (hatvany >= 0)
            {
                Console.WriteLine(Math.Pow(2, hatvany));
                hatvany--;
                //hatvany-=1; így is írhattam volna

            }

            hatvany = 0;
            do
            {
                Console.WriteLine(Math.Pow(2, hatvany));
                hatvany++;

            } while (hatvany<=40);





            Console.ReadKey();
        }
    }
}
