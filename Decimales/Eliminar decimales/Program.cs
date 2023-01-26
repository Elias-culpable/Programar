using System;
namespace Eliminar
{
    class programa
    {
        static void Main(string[] args)
        {
            decimal num = 0;

            Console.WriteLine($"\n-------------------------------------------------------------------");
            Console.WriteLine($"\n\tDime un número con decimales y quitaré sus decimales");
            Console.WriteLine($"\n-------------------------------------------------------------------");

            Console.Write($"\nNúmero: ");
            while (!Decimal.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine($"\n¡Error! Caracter no válido tiene que ser un número");
                Console.Write($"\nEscriba un número válido: ");
            }
            Console.Clear();

            Console.WriteLine($"\n---------------------------------------------");
            Console.Write($"\t {num} Sin decimales  es: {Math.Truncate(num)}");
            Console.WriteLine($"\n---------------------------------------------");
        }
    }
}