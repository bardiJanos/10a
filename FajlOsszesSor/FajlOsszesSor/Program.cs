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
            string[] sorok=null;
            
            try
            {
                sorok = File.ReadAllLines(@"tesztadat_20k.txt", Encoding.Default);
                for (int i = 0; i < sorok.Length; i++)
                {
                    Console.WriteLine(sorok[i]);
                }                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //Kiírás fájlba
            //Általában soronként írunk, de stringet lehet egyben is fájlba írni.
            try
            {   //FileStream létrehozása
                FileStream fajl = new FileStream(@"tesztadat_1k.txt", FileMode.Create);
                StreamWriter wr = new StreamWriter(fajl, Encoding.Default);
                //kiírunk pl. 1000 sort
                for (int i = 0; i < 1000; i++)
                {
                    wr.WriteLine(sorok[i]);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                File.WriteAllLines(@"tesztadat_osszes.txt", sorok, Encoding.Default);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
