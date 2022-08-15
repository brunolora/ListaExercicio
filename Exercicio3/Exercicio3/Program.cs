Console.Write("Digite a hora para Otimista: ");
double otimista = double.Parse(Console.ReadLine());

Console.Write("Digite a hora para Pessimista: ");
double pessimista = double.Parse(Console.ReadLine());

Console.Write("Digite a hora para Provável: ");
double provavel = double.Parse(Console.ReadLine());

double pert = (otimista + pessimista + (4 * provavel)) / 6;

Console.WriteLine($"Otimista: {otimista}");
Console.WriteLine($"Pessimista: {pessimista}");
Console.WriteLine($"Provavel: {provavel}");
Console.WriteLine($"PERT: {pert}");