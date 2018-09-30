using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Delegate {
    class Program {
        public delegate void Print(int num);

        static void Main(string[] args) {
            int num = 0;
            int sumatoria = 0;
            for (int i = 0; i < 5; i++) {
                Console.Write("Ingresa un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                sumatoria += num;
            }
        }

        public static void suma(int num) {
            Console.WriteLine("La suma de los 5 numeros es: {0}", num);
        }
        public static void promedio(int num) {
            Console.WriteLine("El promedio es: {0}", num / 5);
        }
        public static void mayor(int num) {
            int mayor = 0;
            Console.WriteLine("El mayor es es: {0}", mayor);
        }
    }
}
