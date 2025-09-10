Console.WriteLine("Digite o primeiro valor");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"O maior número é {num1}");
}
else
{
    Console.WriteLine($"O maior número é {num2}");
}

