using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgymasbaAgyazott
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   //kivétel dobása
                throw new NullReferenceException();
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Semmi van!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);              
            }


            Console.ReadKey();
        }
    }
}
