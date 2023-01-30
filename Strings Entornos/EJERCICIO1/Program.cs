using System;

namespace EJERCICIO1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cadena;
            string cadena2 = "";
            int contador = 0;


            Console.Write("Introduce una palabra: ");
            cadena = Console.ReadLine();

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                cadena2 = cadena2 + cadena[i];
            }

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == cadena2[i])
                {
                    contador += 1;
                }
            }
            if (contador == cadena.Length && contador == cadena2.Length)
            {
                Console.WriteLine("Es un Palíndromo");
            }
            else
            {
                Console.WriteLine("No es un Palíndromo");
            }


            Console.WriteLine("Pulse enter para finalizar el programa...");
            Console.ReadKey();
        }
    }
}
