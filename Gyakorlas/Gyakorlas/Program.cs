using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            double sugar=19;
            double ker;

            ker = 2 * sugar * Math.PI;

            double kmh;
            double ms;
            double akadaly;

            kmh = 120;
            akadaly = 30;

            if (kmh/3.6>akadaly)
            {
                Console.WriteLine($"Ennyit meg egy másodperc alatt{kmh/3.6},nem áll meg.");
                
            }else
            {
                Console.WriteLine($"Ennyit meg egy másodperc alatt{kmh / 3.6},megáll.");
            }




            //Console.WriteLine(ker);
            Console.ReadKey();
        }
    }
}
