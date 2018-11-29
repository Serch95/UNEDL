using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace DeadLock {
    public class Akshay
    {
        static readonly object firstLock = new object();
        static readonly object secondLock = new object();

        static bool flag = false;

        static void ThreadJob()
        {
            Console.WriteLine("\t\t\t\tLocking firstLock");
            lock (firstLock)
            {
                Console.WriteLine("\t\t\t\tLocked firstLock");
                // Wait until we're fairly sure the first thread
                // has grabbed secondLock
                Thread.Sleep(1001);                
                Console.WriteLine("\t\t\t\tLocking secondLock");
                lock (secondLock)
                {
                    Console.WriteLine("\t\t\t\tLocked secondLock");
                }
                Console.WriteLine("\t\t\t\tReleased secondLock");
                flag = true;
            }
            Console.WriteLine("\t\t\t\tReleased firstLock");
        }
        static void Main()
        {
            int contador = 0;
            new Thread(new ThreadStart(ThreadJob)).Start();
            // Wait until we're fairly sure the other thread
            // has grabbed firstLock
            while (!flag) {
                Thread.Sleep(1);
                contador++;
            }
            Console.WriteLine("El lapso de espera es de: " + contador + "ms");
            Console.WriteLine("Locking secondLock");
            lock (secondLock)
            {
                Console.WriteLine("Locked secondLock");
                Console.WriteLine("Locking firstLock");
                lock (firstLock)
                {
                    Console.WriteLine("Locked firstLock");
                }
                Console.WriteLine("Released firstLock");
            }
            Console.WriteLine("Released secondLock");
            Console.Read();
        }
}
}
