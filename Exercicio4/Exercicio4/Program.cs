Console.Write("Digite a nota do aluno: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
} else if (nota >= 4 && nota < 7) {
    Console.WriteLine("Em Recuperação");
} else {
    Console.WriteLine("Reprovado");
}
