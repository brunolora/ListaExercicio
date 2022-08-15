Console.Write("Um número para calcular o seu fatorial: ");
int x = int.Parse(Console.ReadLine());

int fator = 1;

for (int i = 1; i <= x; i++)
{
    fator *= i;
}

Console.WriteLine($"{x}! = {fator}");