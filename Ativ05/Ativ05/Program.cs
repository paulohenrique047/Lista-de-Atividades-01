Console.WriteLine("Quantos eleitores esse município teve:");
int ele = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos votaram em branco:");
int bra = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos votaram em nulo:");
int nul = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos votos foram válidos:");
int val = int.Parse(Console.ReadLine());
Console.WriteLine($"A porcentagem de pessoas que votaram branco é de {bra / (ele / 100)}%");
Console.WriteLine($"A porcentagem de pessoas que votaram nulo é de {nul / (ele / 100)}%");
Console.WriteLine($"A porcentagem de pessoas que votaram em válido é de {val / (ele / 100)}%");
 