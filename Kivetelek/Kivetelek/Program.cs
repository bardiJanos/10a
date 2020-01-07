using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kivételek kezelése
            //azokat a műveleteket, amelyek kivételt
            //válthatnak ki try..catch blokkba kell rakni

            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sikeres beolvasás!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Számot kell beírni!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("A szám túl nagy");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
               
            }

            


       

            Console.ReadKey();
        }
    }
}
