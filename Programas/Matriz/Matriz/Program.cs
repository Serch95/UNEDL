using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz {
    class Program {
        static void Main(string[] args) {
            int[,] array = new int[4, 5] { { 1, 9, 23, 34, 102 }, { 2, 8, 67, 56, 23 }, { 3, 7, 84, 78, 43 }, { 4, 5, 90, 98, 34 } };
            for (int i = 0; i < 5; i++) {
                if (i % 2 != 0) {
                    for (int j = 3; j >= 0; j--) {
                        Console.Write(array[j, i] + ", ");
                    }
                } else {
                    for (int j = 0; j < 4; j++) {
                        Console.Write(array[j, i] + ", ");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
