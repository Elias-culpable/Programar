using System;

namespace orden_menor_a_mayor
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Orden de un array de menor a mayor");
            Console.WriteLine("--------------------------");
            Console.Write("Tamaño del array: ");
            int NumCel = Convert.ToInt32(Console.ReadLine());
            double[] lista = new double[NumCel];

            for (int i = 0; i < NumCel; i++)
            {
                Console.Write($"\nNum {i + 1}: ");
                lista[i] = Convert.ToDouble(Console.ReadLine());
            }

            Array.Sort(lista);

            for (int i = 0; i < NumCel; i++)
            {
                Console.Write($"{lista[i]} ");
            }
        }
    }
}
