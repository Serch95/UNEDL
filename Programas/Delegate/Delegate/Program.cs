using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate {
    class Program {
        // declare delegate
        public delegate void Print(int value);

        static void Main(string[] args) {
            // Print delegate points to PrintNumber
            Print printDel = PrintNumber;

            Console.WriteLine("Numero");
            printDel(100000);
            printDel(200);            

            //print delegate points to PrintHexadecimal
            printDel = PrintHexadecimal;

            Console.WriteLine("\nHexadecimal");
            printDel(100000);
            printDel(200);            

            // Print delegate points to PrintCientifica
            printDel = PrintCientifica;

            Console.WriteLine("\nNotacion Cientifica");
            printDel(100000);
            printDel(200);

            Console.ReadKey();
        }

        public static void PrintNumber(int num) {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money) {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec) {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }

        public static void PrintCientifica(int num) {
            Console.WriteLine("Hexadecimal: {0:E}", num);
        }
    }

}
