namespace EJERCICIO6
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1;
            string cadena2;

            Console.WriteLine("Introduce una frase");
            cadena1 = Console.ReadLine();

            Console.WriteLine("Ahora que quieres borrar de ella");
            cadena2 = Console.ReadLine();

            cadena1 = cadena1.Replace(cadena2, "");

            Console.WriteLine(cadena1);
            Console.ReadKey();
        }
    }
}