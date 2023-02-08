using System;

namespace calculo_de_minimo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"El mínimo de un array");
            Console.WriteLine("--------------------------");
            Console.Write("Tamaño del array: ");
            int NumCel = Convert.ToInt32(Console.ReadLine());
            double[] lista = new double[NumCel];

            for (int i = 0; i < NumCel; i++)
            {
                Console.Write($"\nNum {i + 1}: ");
                lista[i] = Convert.ToDouble(Console.ReadLine());
            }

            double nuM = lista[0];
            for (int i = 0; i < NumCel; i++)
            {
                if (lista[i] < nuM)
                {
                    nuM = lista[i];
                }
            }
            Console.WriteLine($"\nEl Mínimo es: {nuM}");

        }
    }
}
