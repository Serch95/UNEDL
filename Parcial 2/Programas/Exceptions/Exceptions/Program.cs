using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Exceptions {
    class Program {
        static void Main(string[] args) {
            String nombre;
            int edad;
            double kilos;            

            try {
                Console.WriteLine("Ingresa tu nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa tu edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa tu peso: ");
                kilos = Convert.ToDouble(Console.ReadLine());

                new DB(edad);

            } catch (ExceptionEdad ex) {               
                Console.WriteLine(ex.Message);
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
