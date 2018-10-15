using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo {
    class Program {
        static void Main(string[] args) {
            String palindromo;
            Console.WriteLine("Ingresa una palabra");
            palindromo = Console.ReadLine();
            if (Palindromo(palindromo) == true) {
                Console.WriteLine("Si es un palindromo");
            } else {
                Console.WriteLine("No es un palindromo");
            }
            
            Console.ReadKey();
        }

        public static bool Palindromo(string palindromo) {
            palindromo = palindromo.Replace(" ","");
            int min = 0;
            int max = palindromo.Length - 1;
            while (true) {
                if (min > max) {
                    return true;
                }
                char a = palindromo[min];
                char b = palindromo[max];
                if (char.ToLower(a) != char.ToLower(b)) {
                    return false;
                }
                min++;
                max--;
            }
        }

    }
}
