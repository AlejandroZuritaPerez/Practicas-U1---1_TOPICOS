using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Variables:
             * celsius = double
             * fahrenheit = double
             * 
             * Formula:
             * Fahrenheit = (celsius * 9/5) 32
             */

            Console.WriteLine("Ingrese la temperatura en grados Celsius:");
            double celsius;

            // Leer la temperatura en grados Celsius
            while (!double.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Valor inválido. Por favor, ingrese un número válido:");
            }

            // Convertir de Celsius a Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Mostrar el resultado
            Console.WriteLine($"{celsius} grados Celsius equivalen a {fahrenheit} grados Fahrenheit.");

        }
    }
}
