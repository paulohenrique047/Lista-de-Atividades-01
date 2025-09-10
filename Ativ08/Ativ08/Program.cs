Console.WriteLine("Digite um valor:");
double num = double.Parse(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine($"{num} é positivo.");
}
else
{
    Console.WriteLine($"{num} é negativo.");
}