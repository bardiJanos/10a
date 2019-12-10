using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoJatek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány számmal játszunk?:");
            int hanySzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számból sorsolunk?:");
            int szamTer = Convert.ToInt32(Console.ReadLine());

            int[] tippek = new int[hanySzam];
            int[] nyeroSzamok = new int[hanySzam];
            int talalatok = 0;
            Random rand = new Random();

            Tippeles(szamTer, tippek);
            var soroslasokSzama = 0;
            //TombLista(tippek);
            while (talalatok!=5)
            {

            talalatok = 0;
            Sorsolas(szamTer, nyeroSzamok, rand);

            //Console.WriteLine();

            //TombLista(nyeroSzamok);

            //első, bonyolultabb megoldás
            talalatok = TalalatSzam(tippek, nyeroSzamok, talalatok);

                //Console.WriteLine();
                if (talalatok>1)
                {
                    Console.WriteLine($"Találatok száma:{talalatok}");
                }
            
                soroslasokSzama++;
            }

            TombLista(tippek);
            Console.WriteLine();
            TombLista(nyeroSzamok);

            Console.WriteLine($"Ennyi évbe telt:{soroslasokSzama/52}");
            long koltseg = soroslasokSzama * 250;
            Console.WriteLine($"Költség:{koltseg}");
            ////második, egyszerűbb megoldás
            //talalatok = 0;

            //for (int i = 0; i < tippek.Length; i++)
            //{
            //    if (nyeroSzamok.Contains(tippek[i]))
            //    {
            //        talalatok++;
            //    }
            //}
            //Console.WriteLine($"Találatok száma:{talalatok}");
            Console.ReadKey();
        }

        private static int TalalatSzam(int[] tippek, int[] nyeroSzamok, int talalatok)
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                for (int j = 0; j < nyeroSzamok.Length; j++)
                {
                    if (tippek[i] == nyeroSzamok[j])
                    {
                        talalatok++;
                    }
                }
            }

            return talalatok;
        }

        private static void Sorsolas(int szamTer, int[] nyeroSzamok, Random rand)
        {
            for (int i = 0; i < nyeroSzamok.Length; i++)
            {

                var temp = rand.Next(1, szamTer + 1);
                while (nyeroSzamok.Contains(temp))
                {
                    temp = rand.Next(1, szamTer + 1);
                }
                nyeroSzamok[i] = temp;
            }
        }

        private static void TombLista(int[] tippek)
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                Console.Write(tippek[i] + " ");
            }
        }

        private static void Tippeles(int szamTer, int[] tippek)
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                Console.Write($"{i + 1}.tipp:");
                var temp = Convert.ToInt32(Console.ReadLine());
                while (temp < 1 || temp > szamTer || tippek.Contains(temp))
                {
                    Console.Write($"Rossz tipp!Újra!{i + 1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;
            }
        }
    }
}
