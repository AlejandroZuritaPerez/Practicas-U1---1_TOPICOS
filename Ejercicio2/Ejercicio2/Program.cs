using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de lados del polígono regular:");
            string Lados; // Cambiamos el tipo de dato de int a string

            // Leer el número de lados del polígono
            while (!int.TryParse(Console.ReadLine(), out Lados) || Lados < 3)
            {
                Console.WriteLine("Número de lados inválido. Debe ser un número entero mayor o igual a 3.");
                Console.WriteLine("Ingrese el número de lados del polígono regular:");
            }

            Console.WriteLine("Ingrese la longitud de un lado del polígono regular:");
            double longitudLado;

            // Leer la longitud de un lado del polígono
            while (!double.TryParse(Console.ReadLine(), out longitudLado) || longitudLado <= 0)
            {
                Console.WriteLine("Longitud de lado inválida. Debe ser un número positivo.");
                Console.WriteLine("Ingrese la longitud de un lado del polígono regular:");
            }

            // Calcular el perímetro del polígono regular
            double perimetro = Lados * longitudLado; // Esto generará un error porque Lados es de tipo string

            // Mostrar el resultado
            Console.WriteLine($"El perímetro del polígono regular con {Lados} lados y longitud de lado {longitudLado} es: {perimetro}");


        }
    }
}
