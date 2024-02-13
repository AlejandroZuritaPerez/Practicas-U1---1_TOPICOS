using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Cantidad de dinero = cantidad = double
             * tipo de cambio = double
             * resultado = double
             * 
             */

            Console.WriteLine("Ingrese la cantidad de dinero:");
            double cantidad;

            // Leer la cantidad de dinero
            while (!double.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Cantidad inválida. Por favor, ingrese un número válido:");
            }

            Console.WriteLine("Ingrese el tipo de cambio del día (1 dólar = x euros):");
            double tipoCambio;

            // Leer el tipo de cambio
            while (!double.TryParse(Console.ReadLine(), out tipoCambio) || tipoCambio <= 0)
            {
                Console.WriteLine("Tipo de cambio inválido. Por favor, ingrese un número válido:");
            }

            // Realizar la conversión
            double resultado = cantidad * tipoCambio;

            // Mostrar el resultado
            Console.WriteLine($"{cantidad} dólares equivalen a {resultado} euros.");

        }
    }
}
