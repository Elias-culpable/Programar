using System;

namespace calculo_de_num_primo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Calculo si el número es primo");
            Console.WriteLine("--------------------------");
            Console.Write("Número: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int toke=0;
            for (int i = 2; i < Num; i++)
            {
                if ((Num % i) == 0)
                {
                    toke = 1;
                }
            }
            if (toke==1||Num==1)
            {
                Console.Write($"{Num} no es un número primo");
            }
            else
            {
                Console.Write($"{Num} si es un número primo");
            }
        }
    }
}