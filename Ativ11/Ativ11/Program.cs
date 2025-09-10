using System.IO.Pipes;

Console.WriteLine("Em que ano estamos?");
int ano = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a sua ano você nasceu?");
int nas = int.Parse(Console.ReadLine());
int ida = ano - nas;
if (ida < 16)
{
    Console.WriteLine("Você não é obrigado a votar esse ano");
}
else
{
    if (ida < 69 && ida > 18 )
    {
        Console.WriteLine("Você é obrigdo a votar");
    }
    else
    {
        Console.WriteLine("Seu voto é facultativo");
    }
}