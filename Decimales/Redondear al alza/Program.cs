using System;
namespace redondear
{
    class programa
    {
        static void Main(string[] args)
        {
            decimal num = 0;

            Console.WriteLine($"\n-------------------------------------------------------------------");
            Console.WriteLine($"\n\tDime un número con decimales y lo rendodearé al alza");
            Console.WriteLine($"\n-------------------------------------------------------------------");

            Console.Write($"\nNúmero: ");
            while(!Decimal.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine($"\n¡Error! Caracter no válido tiene que ser un número");
                Console.Write($"\nEscriba un número válido: ");
            }
            Console.Clear();

            Console.WriteLine($"\n---------------------------------------------");
            Console.Write($"\tEl redondeo de {num} es: {Math.Ceiling(num)}");
            Console.WriteLine($"\n---------------------------------------------");
        }
    }
}
