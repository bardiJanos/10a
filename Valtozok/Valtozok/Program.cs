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

            //a változó értékének kiíratása
            Console.WriteLine(szam);

            Console.ReadKey();
        }
    }
}
