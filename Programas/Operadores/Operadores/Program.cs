using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 1.2f;
            int c = 22;

            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("a % b = {0}", a % b);

            if (a == b)
            {
                Console.WriteLine("{0} es igual a {1}", a, b);
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine("{0} es menor a {1}", a, b);
                }
                else if (a == b)
                {
                    Console.WriteLine("{0} es igual a {1}", a, b);
                }
                else
                {
                    Console.WriteLine("{0} es mayor a {1}", a, b);
                }
            }

            if (a == b && a == c)
            {
                Console.WriteLine("{0} es igual a {1} y a {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0} no es igual a {1} ni a {2}", a, b, c);
            }

            int d = a++;
            int e = ++a;

            Console.WriteLine("El valor de d es {0}", d);
            Console.WriteLine("El valor de e es {0}", e);


            Console.ReadKey();
        }
    }
}