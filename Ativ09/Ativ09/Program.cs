Console.WriteLine("Quantas maçãs você irá comprar?");
int maca = int.Parse(Console.ReadLine());
if (maca < 12)
{
    Console.WriteLine($"Você terá que pagar R${maca * 1.3}");
}
else
{
    Console.WriteLine($"Você terá que pagar R${maca * 1}");
}