

namespace EJERCICIO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string entrada;
            string letra;
            int contador = 0;

            //Solicitamos al variable 
            Console.Write("Introduce una cadena: ");
            entrada = Console.ReadLine();
            Console.Write("Introduce una letra para buscar el nº de veces que se repite: ");
            letra = Console.ReadLine();

            entrada.ToLower();
            letra.ToLower();

            
            for (int i = 0; i < entrada.Length; i++)
            {
                if (letra.ElementAt(0) == entrada.ElementAt(i))
                {
                    contador++;
                }
            }

            Console.WriteLine("La letra {0}, se repite : {1} veces. ", letra, contador);

            
            Console.WriteLine("Pulse enter para finalizar el programa...");
            Console.ReadKey();

        }
    }
}
