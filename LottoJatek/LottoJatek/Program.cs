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

            for (int i = 0; i < tippek.Length; i++)
            {
                Console.Write($"{i+1}.tipp:");
                var temp= Convert.ToInt32(Console.ReadLine());
                while (temp<1 || temp>szamTer || tippek.Contains(temp))
                {
                    Console.Write($"Rossz tipp!Újra!{i + 1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;
            }

            for (int i = 0; i < tippek.Length; i++)
            {
                Console.Write(tippek[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
