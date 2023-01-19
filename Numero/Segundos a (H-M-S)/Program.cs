using System;

namespace segundos_a_HMS
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Segundos a horas minutos y segundos");
            Console.WriteLine("--------------------------");
            Console.Write("Segundos: ");
            int Num,H,M,S;
            Num = Convert.ToInt32(Console.ReadLine());

            H =Num/3600;
            M =(Num-3600*H)/60;
            S = Num - (H * 3600 + M * 60);

            Console.WriteLine($"El total en segundos de {Num} son {H} horas, {M} Minutos y {S} Segundos");
        }
    }
}