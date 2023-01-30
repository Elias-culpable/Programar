

using System;

namespace EJERCICIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            string cadena2;
            Console.WriteLine("Escribe un nombre y te lo paso a mayúscula: ");
            cadena = Console.ReadLine();
            cadena = cadena.ToUpper();
            Console.WriteLine("Convertido en mayúsculas: {0}", cadena);
            
            Console.WriteLine("Ahora escribe otro nombre y te lo paso a minúscula: ");
            cadena2 = Console.ReadLine();
            cadena2 = cadena2.ToLower();
            Console.WriteLine("Convertido en minúsculas: {0}", cadena2);

            Console.WriteLine("Pulse enter para finalizar el programa...");
            Console.ReadKey();
        }
    }
}
