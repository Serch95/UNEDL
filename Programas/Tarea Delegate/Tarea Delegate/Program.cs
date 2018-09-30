using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Delegate {
    class Program {
        public delegate void Print(int[] num);

        static void Main(string[] args) {
            int[] num = new int[5];
            try {
                for (int i = 0; i < 5; i++) {
                    Console.Write("Ingresa un numero:");
                    num[i] = Convert.ToInt32(Console.ReadLine());
                }
                Print printSuma = Suma;
                printSuma(num);

                Print printPromedio = Promedio;
                printPromedio(num);

                Print printMayor = Mayor;
                printMayor(num);
            } catch (Exception ex) {
                Console.WriteLine("Solo se pueden ingresar numeros");
            }
            Console.ReadKey();
        }

        public static void Suma(int[] num) {
            int suma = 0;
            for (int i = 0; i < 4; i++) {
                suma += num[i];
            }
            Console.WriteLine("\nLa suma de los 5 numeros es: {0}", suma);
        }
        public static void Promedio(int[] num) {
            int suma = 0;
            for (int i = 0; i < 4; i++) {
                suma += num[i];
            }
            Console.WriteLine("El promedio es: {0}", suma / 5);
        }
        public static void Mayor(int[] num) {
            int mayor = 0;
            for (int i = 0; i < 5; i++) {
                if (num[i] > mayor) {
                    mayor = num[i];
                }
            }
            Console.WriteLine("El mayor es es: {0}", mayor);
        }
    }
}
