using System;
using System.Diagnostics.Contracts;

namespace Numeros_de_Armstrong
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Comprobador de número de Armstrong");
            Console.WriteLine("--------------------------");
            Console.Write("Numero: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int cant = Convert.ToString(Num).Length;
            double Sum=0;
            for (int i = 0; i < cant; i++)
            {
                char  s = Convert.ToString(Num)[i];
                Sum += Math.Pow(Char.GetNumericValue(Convert.ToString(Num)[i]), cant);
            }
            if (Sum==Num)
            {
                Console.Write($"{Num} si es un número de Armstrong");
            }
            else
            {
                Console.Write($"{Num} no es un número de Armstrong");
            }
        }
    }
}