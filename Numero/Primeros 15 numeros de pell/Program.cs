using System;

namespace Numeros_de_Pell
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Primeros 15 números de la serie de Pell");
            Console.WriteLine("--------------------------");
            int num1 = 1, num2 = 0, num3 = 1;
            for (int i = 0; i < 15; i++)
            {
                num1 = (num2 * 2) + num3;
                Console.WriteLine($"{num1}");
                num3 = num2;
                num2 = num1;
            }
        }
    }
}