using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fajl = new FileStream(@"tesztadat_20k.txt", FileMode.Open);
                StreamReader reader = new StreamReader(fajl, Encoding.Default);

                while (!reader.EndOfStream)
                {
                    var sor = reader.ReadLine();
                    Console.WriteLine(sor);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }


            


            Console.ReadKey();    
        }
    }
}
