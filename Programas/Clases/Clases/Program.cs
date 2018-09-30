using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            libro libro;
            Console.WriteLine("Tipos de datos:");
            obj.tiposDatos();
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Operadores:");
            obj.operadores();
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Estructura:");
            libro.nombre = "El principito";
            libro.numPaginas = 91;
            libro.autor = "antoine de saint exupery";
            libro.editorial = "Leyenda";

            Console.WriteLine("Libro\nNombre: {0}\nAutor: {1}\nNumero de paginas: {2}\nEditorial: {3}", libro.nombre, libro.autor, libro.numPaginas, libro.editorial);

            Console.ReadKey();


        }

        public void tiposDatos()
        {
            byte var1 = 10;
            short var2 = 12000;
            int var3 = 100000;
            long var4 = 89;
            float var5 = 1.1f;
            double var6 = 133.89d;
            decimal var7 = 1000.999M;
            char var8 = 'A';
            bool var9 = true;
            String var10 = "Sergio";

            var var11 = "Unedl";
            var var12 = 'J';
            var var13 = 12;
            var var14 = -555;
            var var15 = 11.2;
            var var16 = false;

            int var36 = (int)var6;
            decimal var73 = (decimal)var3;
            double var62 = Convert.ToDouble(var2);
            long var47 = Convert.ToInt64(var7);
            char var810 = Convert.ToChar(var10[0]);

            Console.WriteLine("byte = {0}", var1);
            Console.WriteLine("short = {0}", var2);
            Console.WriteLine("int = {0}", var3);
            Console.WriteLine("long = {0}", var4);
            Console.WriteLine("float = {0}", var5);
            Console.WriteLine("double = {0}", var6);
            Console.WriteLine("decimal = {0}", var7);
            Console.WriteLine("char = {0}", var8);
            Console.WriteLine("bool = {0}", var9);
            Console.WriteLine("String = {0}", var10);
            Console.WriteLine("var = {0}", var11);
            Console.WriteLine("var = {0}", var12);
            Console.WriteLine("var = {0}", var13);
            Console.WriteLine("var = {0}", var14);
            Console.WriteLine("var = {0}", var15);
            Console.WriteLine("var = {0}\n", var16);


            Console.WriteLine("double to int = {0} -> {1}", var6, var36);
            Console.WriteLine("int to decimal = {0} -> {1}", var3, var73);
            Console.WriteLine("short to double = {0} -> {1}", var2, var62);
            Console.WriteLine("decimal to long = {0} -> {1}", var7, var47);
            Console.WriteLine("String to char = {0} -> {1}\n", var10, var810);
        }

        public void operadores()
        {
            int a = 10;
            float b = 1.2f;
            int c = 22;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
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
        }

        struct libro
        {
            public String nombre;
            public int numPaginas;
            public String editorial;
            public String autor;
        }
    }

}