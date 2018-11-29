using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.IO;

namespace Reloj_chequador__Threads_ {
    class Program {

        const int personas = 5;
        private static ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();
        static Random rnd = new Random();

        static void Main(string[] args) {
            string rutaCompleta = @" C:\Users\Sergio\source\repos\Parcial 2\Documentos\Registro.txt";
            GenerarTXT(rutaCompleta);
            Thread[] t = new Thread[personas];

            for (int i = 0; i < personas; i++) {
                t[i] = new Thread(new ThreadStart(proceso));
                switch (i) {
                    case 0:
                        t[0].Name = "Sergio";
                        break;
                    case 1:
                        t[1].Name = "Many";
                        break;
                    case 2:
                        t[2].Name = "Chatmajo";
                        break;
                    case 3:
                        t[3].Name = "Brian";
                        break;
                    case 4:
                        t[4].Name = "Miguel";
                        break;
                }

                t[i].Start();                
            }            
            Console.ReadKey();
        }

        static public void proceso() {
            string rutaCompleta = @" C:\Users\Sergio\source\repos\Parcial 2\Documentos\Registro.txt";
            WriteToFileThreadSafe(rutaCompleta);


        }

        static public void WriteToFileThreadSafe(String rutaCompleta) {
            // Set Status to Locked
            _readWriteLock.EnterWriteLock();
            try {
                // Append text to the file                
                escribirEntrada(rutaCompleta);                                
            } finally {
                // Release lock
                _readWriteLock.ExitWriteLock();
            }

            double espera = rnd.Next(500, 3000);
            Thread.Sleep((int) espera);

            _readWriteLock.EnterWriteLock();
            try {
                // Append text to the file                
                escribirSalida(rutaCompleta);
            } finally {
                // Release lock
                _readWriteLock.ExitWriteLock();
            }
        }

        static public String getFecha() {
            DateTime dateTime = DateTime.Now;
            var culture = new CultureInfo("es-MX");
            return dateTime.ToString(culture);
        }

        static void GenerarTXT(String rutaCompleta) {
            using (StreamWriter mylogs = File.AppendText(rutaCompleta)) {

                mylogs.Close();
            }
        }

        static void escribirEntrada(String rutaCompleta) {
            using (StreamWriter file = new StreamWriter(rutaCompleta, true)) {
                file.WriteLine(Thread.CurrentThread.Name + " , Entrada , " + getFecha() + Environment.NewLine);
                Console.WriteLine(Thread.CurrentThread.Name + " , Entrada , " + getFecha());
                file.Close();
            }
        }

        static void escribirSalida(String rutaCompleta) {
            using (StreamWriter file = new StreamWriter(rutaCompleta, true)) {
                file.WriteLine(Thread.CurrentThread.Name + " , Salida , " + getFecha() + Environment.NewLine);
                Console.WriteLine(Thread.CurrentThread.Name + " , Salida , " + getFecha());
                file.Close();
            }
        }        
    }
}


