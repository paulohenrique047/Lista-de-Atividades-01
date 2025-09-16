using System;

namespace ImprimirNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor para N: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine($"\nValores inteiros entre 1 e {n}:");
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("O valor de N deve ser maior que zero!");
            }
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
