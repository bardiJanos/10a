using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    class Program
    {
        static void Main(string[] args)
        {
            //A lista a Nobeldijas osztály példányait fogja tárolni
            List<Nobeldijas> nobeldijasok = new List<Nobeldijas>();
            //Fájl betöltése
            try
            {
                FileStream fajl = new FileStream(@"nobel.csv", FileMode.Open);
                using (StreamReader reader = new StreamReader(fajl, Encoding.Default))
                { 
                    reader.ReadLine();//Átlépjük az első sort
                while (!reader.EndOfStream)
                {   //A fájl egy sorának feldarabolása az elválasztó karakter mentén
                    var e = reader.ReadLine().Split(';');
                    Nobeldijas nobeldijas = new Nobeldijas(Convert.ToInt32(e[0]),e[1],e[2],e[3]);
                    nobeldijasok.Add(nobeldijas);
                }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Nobel díjasok száma:{nobeldijasok.Count}");
            //2017 irodalmi nobel díjasa:
            for (int i = 0; i < nobeldijasok.Count; i++)
            {
                if (nobeldijasok[i].Ev==2017 && nobeldijasok[i].Tipus=="irodalmi")
                {
                    Console.WriteLine($"{nobeldijasok[i].Vezeteknev},{nobeldijasok[i].Keresztnev}");
                }
            }
            //Ugyanez  C# beépített lekérdezőjével (LINQ)
            var irodalmi2017 = nobeldijasok.FindAll(x=>x.Ev==2017 && x.Tipus=="irodalmi");

            foreach (var i in irodalmi2017)
            {
                Console.WriteLine($"{i.Vezeteknev},{i.Keresztnev}");
            }

            var _irodalmi2017 = nobeldijasok.Find(x => x.Ev == 2017 && x.Tipus == "irodalmi");

            Console.WriteLine($"{_irodalmi2017.Vezeteknev},{_irodalmi2017.Keresztnev}");

            var milyenDijat = nobeldijasok.Find(x=>x.Keresztnev=="Arthur B." && x.Vezeteknev=="McDonald");
            var milyenDijat2 = nobeldijasok.FindAll(x => x.Keresztnev == "Arthur B." && x.Vezeteknev == "McDonald");
            //szervezetek lekérdezése
            var szervezetek = nobeldijasok.FindAll(x=>x.Vezeteknev=="").OrderBy(x=>x.Ev);

            foreach (var i in szervezetek)
            {
                Console.WriteLine($"{i.Ev},{i.Keresztnev},{i.Tipus}");
            }


            if (milyenDijat!=null)
            {
                Console.WriteLine($"{milyenDijat.Tipus}");
            } else
            {
                Console.WriteLine("Nincs ilyen adat!");
                Console.WriteLine(milyenDijat2.Count);
            }
            //csoportosítás
            var tipusok = nobeldijasok.ToLookup(x=>new { x.Ev,x.Tipus });

            foreach (var i in tipusok)
            {
                Console.WriteLine($"{i.Key.Ev},{i.Key.Tipus},{i.Count()}");
            }

            var orvosi = nobeldijasok.FindAll(x=>x.Tipus=="orvosi");

            Console.WriteLine($"{orvosi.Count}");

            Console.ReadKey();
        }
    }
}
