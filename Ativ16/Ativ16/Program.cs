using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para calcular o fatorial: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Não existe fatorial de número negativo!");
        }
        else
        {
            long fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }
            Console.WriteLine($"{n}! = {fatorial}");
        }
        Console.ReadKey();
    }
}
