Console.Write("O valor de A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("O valor de B: ");
int B = int.Parse(Console.ReadLine());

if (A % B == 0 || B % A == 0)
{
    Console.WriteLine("Os números são Múltiplos");
} else {
    Console.WriteLine("Os números não são Múltiplos");
}