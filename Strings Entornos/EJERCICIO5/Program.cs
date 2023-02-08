namespace EJERCICIO5
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;

            Console.WriteLine("Introduce una frase");
            cadena = Console.ReadLine();

            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(cadena[i]);
                }
            }
            Console.ReadKey();
        }
    }
}