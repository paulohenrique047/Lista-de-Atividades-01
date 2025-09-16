using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números entre 1000 e 2000 que divididos por 11 dão resto 5:");
        int contador = 0;
        for (int numero = 1000; numero <= 2000; numero++)
        {
            if (numero % 11 == 5)
            {
                Console.Write($"{numero} ");
                contador++;

                if (contador % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine($"\n\nTotal de números encontrados: {contador}");
    }
}
