using System;

namespace calculo_de_la_media
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"La media de un array");
            Console.WriteLine("--------------------------");
            Console.Write("Tamaño del array: ");
            int NumCel = Convert.ToInt32(Console.ReadLine());
            double[] lista = new double[NumCel];

            double med=0;

            for (int i = 0; i < NumCel; i++)
            {
                Console.Write($"\nNum {i + 1}: ");
                lista[i] = Convert.ToDouble(Console.ReadLine());
                med += lista[i];
            }

            med = med / NumCel;
            Console.WriteLine($"\nLa Media es: {med} ");
        }
    }
}
