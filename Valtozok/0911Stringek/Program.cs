using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0911Stringek
{
    class Program
    {
        static void Main(string[] args)
        {
            String szoveg = "Minta szöveg";
            var masikSzoveg = "Másik minta szöveg";

            szoveg = "Izé, meg még valami...";

            Console.WriteLine(szoveg);
            //Az első karakter
            Console.WriteLine(szoveg[0]);
            //Milyen hosszú?
            Console.WriteLine(szoveg.Length);
            //a szoveg változó 22 karakter hosszú
            //az egyes karakterek indexei 0-21 közöttiek

            //kisbetűsre alakítás
            Console.WriteLine(szoveg.ToLower());
            //nagybetűsre alakítás
            Console.WriteLine(szoveg.ToUpper());

            //kezdődik valamilyen szöveggel?
            Console.WriteLine(szoveg.StartsWith("izé"));

            var szoveg1 = "Izé";
            var szoveg2 = "iZÉ";

            szoveg1 = szoveg1.ToLower();
            szoveg2 = szoveg2.ToLower();

            if (szoveg1.Equals(szoveg2)) 
            {
                Console.WriteLine("A szövegek egyenlőek!");
            }else
            {
                Console.WriteLine("A szövegek nem egyenlőek!");
            }

            //Szöveg rész szövege
            Console.WriteLine(szoveg.Substring(2,6));

            //karakterek cseréje
            Console.WriteLine(szoveg.Replace('m','n'));

            //szóközök eltüntetése
            Console.WriteLine(szoveg.Replace(" ", ""));

            //Karakteres változók

            Char kar = '8';

            if (Char.IsDigit(kar))
            {
                Console.WriteLine("Ez egy szám");
                Console.WriteLine(Char.GetNumericValue(kar)+10);
            }



            Console.ReadKey();
        }
    }
}
