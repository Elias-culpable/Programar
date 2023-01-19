using System;

namespace digitos_diferentes
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Devolver si un número tiene todos sus dígitos diferentes");
            Console.WriteLine("--------------------------");
            Console.Write("Numero: ");
            int val =0,Num = Convert.ToInt32(Console.ReadLine());
            string cad = Convert.ToString(Num);


            for (int i=0;i < cad.Length;i++)
            {
               int val1 = 0;
                for (int ie = 0; ie < cad.Length; ie++)
                {
                    if (cad[i] == cad[ie])
                    {
                        val1++;
                    }
                    if (val1==2)
                    {
                        val =1;
                    }
                }
            }
            if (val==1)
            {
                Console.Write($"{Num} tiene digitos repetidos");
            }
            else
            {
                Console.Write($"{Num} no tiene digitos repetidos");
            }
        }
    }
}