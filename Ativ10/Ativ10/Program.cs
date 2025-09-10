using System.Net.Http.Headers;

Console.WriteLine("Qual foi a sua nota na 1ª avaliação?");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Qual foi a sua nota na 2ª avaliação?");
double num2 = double.Parse(Console.ReadLine());
double Media = (num1 + num2) / 2;
if (Media < 6)
{
    Console.WriteLine($"Sua média foi {Media}, você não foi aprovado!");
}
else
{
    Console.WriteLine($"Sua média foi {Media}, você foi aprovado!");
}