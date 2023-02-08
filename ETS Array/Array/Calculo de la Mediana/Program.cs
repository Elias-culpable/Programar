using System;

namespace calculo_de_la_mediana
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"La mediana de un array");
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

            if (NumCel%2==0)
            {
                Console.WriteLine($"\nLos números:{lista[(NumCel/2)-1]} y {lista[NumCel / 2]} hacen la mediana: {((lista[NumCel / 2-1])+(lista[NumCel / 2]))/2}");
            }
            else
            {
                Console.WriteLine($"\nLa mediana es: {lista[((NumCel/2)+(NumCel % 2))-1]}");
            }
        }
    }
}
