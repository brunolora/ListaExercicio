Console.Write("Valor de N: ");
int n = int.Parse(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("Só é válido número inteiro positivo");
} else {
    for (int i = 1; i <= n; i++)
    {
        int primeiro = i;
        int segundo = i * i;
        int terceiro = i * i * i;
        Console.WriteLine($"{primeiro} {segundo} {terceiro}");
    }
}