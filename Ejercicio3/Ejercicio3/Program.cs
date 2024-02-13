using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Variables:
               grados = double
               Radianes = double
               Pi = Math.PI

                Formula:
               (grados * Pi) / 180
            */

            Console.WriteLine("Ingrese el valor en grados:");
            double grados;

            // Leer el valor en grados
            while (!double.TryParse(Console.ReadLine(), out grados))
            {
                Console.WriteLine("Valor inválido. Por favor, ingrese un número válido:");
            }

            // Convertir de grados a radianes
            double radianes = (grados * Math.PI) / 180;

            // Mostrar el resultado
            Console.WriteLine($"{grados} grados equivalen a {radianes} radianes.");

        }
    }
}
