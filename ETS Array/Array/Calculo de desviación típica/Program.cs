using System;

namespace calculo_de_la_desviacion_tipica
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"La desviación típica de un array");
            Console.WriteLine("--------------------------");
            Console.Write("Tamaño del array: ");
            int NumCel = Convert.ToInt32(Console.ReadLine());
            double[] lista = new double[NumCel];

            double med = 0,predt=0,DT=0;

            for (int i = 0; i < NumCel; i++)
            {
                Console.Write($"\nNum {i + 1}: ");
                lista[i] = Convert.ToDouble(Console.ReadLine());
                med += lista[i];
            }

            med = med / NumCel;

            for (int i = 0; i < NumCel; i++)
            {
                predt += Math.Pow((lista[i]-med), 2);
            }
            DT= Math.Sqrt(predt/NumCel); ;
            Console.WriteLine($"\nLa desviación típica es: {DT}");
        }
    }
}
