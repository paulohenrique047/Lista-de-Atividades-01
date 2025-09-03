Console.WriteLine("Qual o salário mensal do funcionário:");
int sal = int.Parse(Console.ReadLine());
Console.WriteLine("Quanto de porcentagem será o reajuste do salário:");
int rea = int.Parse(Console.ReadLine());
Console.WriteLine($"O salário do funcionário atual agora é de {(sal / 100) * rea + sal}");




