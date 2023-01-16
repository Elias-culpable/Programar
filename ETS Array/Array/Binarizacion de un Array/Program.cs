using System;

namespace calculo_de_la_desviacion_tipica
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Binarizacion de un aray");
            Console.WriteLine("--------------------------");
            Console.Write("Tamaño del array: ");
            int NumCel = Convert.ToInt32(Console.ReadLine());
            double[] lista = new double[NumCel];

            Console.Write("Base de la Binarizacion: ");
            double BBina = Convert.ToDouble(Console.ReadLine());


            for (int i = 0; i < NumCel; i++)
            {
                Console.Write($"\nNum {i + 1}: ");
                lista[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < NumCel; i++)
            {
                if (lista[i]<BBina)
                {
                    lista[i] =0;
                }
                else
                {
                    lista[i] = 1;
                }
                Console.Write($"{lista[i]} ");
            }

        }
    }
}