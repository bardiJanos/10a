using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajlOsszesSor
{
    class Program
    {
        static void Main(string[] args)
        {

            
            try
            {
                var sorok = File.ReadAllLines(@"tesztadat_20k.txt", Encoding.Default);
                for (int i = 0; i < sorok.Length; i++)
                {
                    Console.WriteLine(sorok[i]);
                }                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
