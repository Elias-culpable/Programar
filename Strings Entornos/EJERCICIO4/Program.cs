namespace EJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1;
            string cadena2;
            int num;

            Console.WriteLine("Introduce una frase");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Introduce otra frase");
            cadena2 = Console.ReadLine();
            Console.WriteLine("Introduce un numero");
            while (!Int32.TryParse(Console.ReadLine(), out num) || num <= 0)
                Console.WriteLine("Esto no es un numero");

            for (int i = 0; i < num; i++)
                Console.Write(cadena1 + " " + cadena2 + " ");
            Console.ReadKey();
        }
    }
}