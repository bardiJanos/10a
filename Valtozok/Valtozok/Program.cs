using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok
{
    class Program
    {
        static void Main(string[] args) //a program belépési pontja
        {
            //ami itt van, az hajtódik végre
            Console.WriteLine("Gyá!");
            //változók
            //egész számok

            //szam nevű, int típusú változó létrehozása
            int szam;

            //értékadás, a bal oldali változó kapja meg a jobb
            //oldalon lévő értéket
            szam = 117;

            szam = 19;

            //változóknak adjunk beszédes neveket
            int masikSzam = 19;

            masikSzam = 39;

            short kisEgesz = 45;

            long nagyEgesz = 55567;

            Console.WriteLine($"Int32 max:{Int32.MaxValue} Int32 min:{Int32.MinValue}");

            Console.WriteLine($"UInt32 max:{UInt32.MaxValue} UInt32 min:{UInt32.MinValue}");

            //byte típus
            byte bajt = 129;

            //nem egész számok tárolása,deklaráció
            float egyszeres = 15.39445456466525443f;
            double ketszeres = 15.39445456466525443;
            decimal dec = 15.39445456466525443m;

            Console.WriteLine($"Float:{egyszeres}, Double:{ketszeres}, Decimal:{dec}");
            //a változó értékének kiíratása
            Console.WriteLine(szam);

            Console.ReadKey();
        }
    }
}
