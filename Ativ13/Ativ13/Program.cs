Console.WriteLine("Digite três números para ver a ordem crescente deles:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1 < num2 && num2 < num3)
{
    Console.WriteLine($"A ordem crescente é {num1}, {num2}, {num3}");
}
else if (num1 < num3 && num3 < num2)
{
    Console.WriteLine($"A ordem crescente é {num1}, {num3}, {num2}");
}
else if (num2 < num1 && num1 < num3)
{
    Console.WriteLine($"A ordem crescente é {num2}, {num1}, {num3}");
}
else if (num2 < num3 && num3 < num1)
{
    Console.WriteLine($"A ordem crescente é {num2}, {num3}, {num1}");
}
else if (num3 < num1 && num1 < num2)
{
    Console.WriteLine($"A ordem crescente é {num3}, {num1}, {num2}");
}
else
{
    Console.WriteLine($"A ordem crescente é {num3}, {num2}, {num1}");
}