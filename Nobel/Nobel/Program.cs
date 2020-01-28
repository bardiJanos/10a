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
            Console.ReadKey();
        }
    }
}
