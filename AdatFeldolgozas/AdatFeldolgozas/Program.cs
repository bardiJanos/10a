using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatFeldolgozas
{
    class Program
    {
        struct Szemely
        {
            public string vezeteknev;
            public string keresztnev;
            public int szuletesEve;
            public string szuletesiHely;
        }

        static void Main(string[] args)
        {
            //Lista létrehozása
            List<Szemely> szemelyek = new List<Szemely>();
            //struktúra példány létrehozása
            Szemely szemely = new Szemely();

            try
            {
                //Filestream létrehozása a beolvasáshoz
                FileStream fajl = new FileStream(@"tesztadat_20k.txt", FileMode.Open);
                //a streamreader olvassa a fájl majd
                StreamReader reader = new StreamReader(fajl,Encoding.Default);

                while (!reader.EndOfStream)
                {
                    //a cikluson belül dolgozzuk fel a fájlból beolvasott sorokat
                    //a fájlból beolvasott sort a , karakter mentén a split 
                    //elvágja, a részeket egy tömbbe teszi
                    var adat = reader.ReadLine().Split(',');

                    //kitöltjük a struktúrapéldány mezőit adatokkal
                    szemely.vezeteknev = adat[0];
                    szemely.keresztnev = adat[1];
                    szemely.szuletesEve = Convert.ToInt32(adat[2]);
                    szemely.szuletesiHely = adat[3];

                    //a struktúra példányát a listához hozzáadjuk

                    szemelyek.Add(szemely);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Ha van kivétel, kiíratjuk az üzenetét
                Console.WriteLine(ex.Message);
            }

            //Itt tudunk valamit kezdeni az adatokkal
            Console.WriteLine($"Adatok száma:{szemelyek.Count}");

            //az 1980 után születettek kiválogatása
            var nyolcvanas = szemelyek.FindAll(x => x.szuletesEve == 1980);

            //a nyolcvanas lista kiíratása
            //ehhez a foreach a legjobb

            foreach (var i in nyolcvanas)
            {
                Console.WriteLine($"{i.vezeteknev},{i.keresztnev},{i.szuletesEve},{i.szuletesiHely}");
            }

            //Hány darab adat ez:
            Console.WriteLine($"Adatok száma:{nyolcvanas.Count}");


            var elsonyolcvanas = szemelyek.Find(x => x.szuletesEve == 1980);

            Console.WriteLine($"{elsonyolcvanas.vezeteknev},{elsonyolcvanas.keresztnev}");
            //kiírás fájlba
            try
            {   //egy FileStream és egy streamwriter kell
                FileStream outFajl = new FileStream(@"nyolcvan.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(outFajl,Encoding.Default);

                foreach (var i in nyolcvanas)
                {
                    writer.WriteLine($"{i.vezeteknev},{i.keresztnev},{i.szuletesEve},{i.szuletesiHely}");
                }
                //le kell zárni, különben nem íródik ki az összes sor
                writer.Close();
                Console.WriteLine("Kiírás vége!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
