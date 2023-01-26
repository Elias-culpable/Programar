using ecuacion_de_segundo_grado__3_coeficientes_;
using System;
namespace Ecuacion_Segundo_Grado
{
    class programa
    {
        static void Main(string[] args)
        {
    
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;

            Console.WriteLine($"\n-------------------------------------------------------------------------------");
            Console.WriteLine($"\n\tDime 3 coheficientes y te calcularé la ecuación de segundo grado");
            Console.WriteLine($"\n-------------------------------------------------------------------------------");

            Console.Write($"Primer número: ");
            while(!Double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine($"¿Error!  Caracter no válido, tiene que ser un número");
            }
            Console.Clear();

            Console.Write($"Segundo número: ");
            while (!Double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine($"¿Error!  Caracter no válido, tiene que ser un número");
            }
            Console.Clear();

            Console.Write($"Tercer número: ");
            while (!Double.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine($"¿Error!  Caracter no válido, tiene que ser un número");
            }
            Console.Clear();

            Console.WriteLine($"\n\tResultados de la ecuación de segundo grado\n\tPrimer resultado: {Funciones.Ecuacion1(num1,num2,num3)}\n\tSegundo resultado: {Funciones.Ecuacion2(num1,num2,num3)} ");
        }
    }
}