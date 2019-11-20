using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsszetettTipus
{
    class Program
    {
        //struktúra, azaz összetett adattípus
        //létrehozása
        struct Szemely {
            public string vezeteknev;
            public string keresztnev;
            public int szuletesEve;
            public int magassag;
        }

        static void Main(string[] args)
        {
            //A listán szereplő elemek Szemely típusúak
            //A Szemely típust a struct (struktúra) írja le.
            List<Szemely> szemelyek = new List<Szemely>();

            //Kell egy példány a Személy típusból
            Szemely valaki = new Szemely();

            //Mostmár lehet értéket adni a valaki-nek
            valaki.vezeteknev = "Nagy";
            valaki.keresztnev = "Ubul";
            valaki.szuletesEve = 2001;
            valaki.magassag = 188;

            //A valaki-t mostmár hozzá lehet adni a listához
            szemelyek.Add(valaki);

            valaki.vezeteknev = "Kerekes";
            valaki.keresztnev = "Eufrozina";
            valaki.szuletesEve = 1988;
            valaki.magassag = 168;

            szemelyek.Add(valaki);

            //A lista elemeinek kiíratása
            for (int i = 0; i < szemelyek.Count; i++)
            {
                Console.WriteLine($"Név:{szemelyek[i].vezeteknev}, Keresztnév:{szemelyek[i].keresztnev} ");
            }

            //A lista elemeinek kiírtása foreach-el
            foreach (var v in szemelyek)
            {
                Console.WriteLine($"Veznév:{v.vezeteknev},{v.keresztnev},{v.magassag},{v.szuletesEve}");
            }

            Console.ReadKey();
        }
    }
}
