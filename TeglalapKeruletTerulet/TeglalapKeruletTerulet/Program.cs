using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeglalapKeruletTerulet
{
    class Program
    {
        public static int Kerulet(int a,int b)
        {
            return (a + b) * 2;
        }

        public static int Terulet(int a, int b)
        {
            return a * b;
        }

        public static double Terulet(double a, double b)
        {
            return a * b;
        }


        static void Main(string[] args)
        {
            //Írjon programot, amely tartalmaz két függvényt
            //egy téglalap kerületének valamint területének
            //a kiszámítására! A bemenő adatok a téglalap
            //oldalai legyenek!

            Console.WriteLine(Kerulet(5,10));
            Console.WriteLine(Terulet(5, 10));
            Console.WriteLine(Terulet(5.278, 10.2234));


            Console.ReadKey();
        }

        //ide
    }
}
