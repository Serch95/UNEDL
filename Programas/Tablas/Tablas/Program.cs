using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 0;
            Console.WriteLine("Ingresa el numero que deseas (1 to 10)");
            try
            {
                n1 = Convert.ToByte(Console.ReadLine());
                if (n1 > 0 && n1 <= 10)
                {
                    for (byte i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("{0} X {1} = {2}", n1, i, (n1 * i));
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa un valor dentro del rango");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ingresa lo que se indica");
            }

            Console.ReadKey();
        }
    }
}