
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            while (op != 5)
            {
                Console.WriteLine("\t\t.:Digite una opcion:." +
                    "\n1. Suma" +
                    "\n2. Resta" +
                    "\n3. Multiplicacion" +
                    "\n4. Division" +
                    "\n5. Salir");
                Console.Write("=> ");
                op = int.Parse(Console.ReadLine());
                if (op == 5)
                {
                    break;
                }

                Console.WriteLine("\nDigite un numero: ");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite un numero: ");
                double b = double.Parse(Console.ReadLine());

                double resultado = Calculadora(a, b, op);
                Console.WriteLine("\nEl resulado es: " + resultado);

                Console.ReadLine();
                Console.Clear();
            };

        }

        static double Calculadora(double a, double b, int op)
        {
            double resultado = 0;

            switch (op)
            {
                case 1: resultado = a + b; break;
                case 2: resultado = a - b; break;
                case 3: resultado = a * b; break;
                case 4: resultado = a / b; break;
                default: resultado = 0; break;
            }

            return resultado;
        }
    }
}

