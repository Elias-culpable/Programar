using System;

namespace calculo_del_factorial
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Calculo del factorial");
            Console.WriteLine("--------------------------");
            Console.Write("Numero Factorial: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int Resul =1;
            if (Num<0)
            {
                Console.Write($"No se pueden");
            }
            else
            {
                for (int i = 1; i <= Num; i++)
                {
                    Resul = Resul * i;
                }
            }
            
            Console.Write($"El resultado del factorial de {Num} es: {Resul}");
        }
    }
}