//Leituras dos valores
Console.Write("O valor A: ");
double valorA = double.Parse(Console.ReadLine());

Console.Write("O valor B: ");
double valorB = double.Parse(Console.ReadLine());

Console.Write("O valor C: ");
double valorC = double.Parse(Console.ReadLine());

//A
double area = (valorA * valorC) / 2;
Console.WriteLine($"A área do triângulo é: {area}");

//B
double pi = 3.14;
double raioC = pi * (valorC * valorC);
Console.WriteLine($"A área do círculo de raio C é: {raioC:F2}");

//C
double trapezio = ((valorA + valorB) * valorC) / 2;
Console.WriteLine($"A área do trapézio é: {trapezio}");

//D
double area2 = valorB * valorB;
Console.WriteLine($"O valor da área do quadrado é: {area2}");

//E
double area3 = valorA * valorB;
Console.WriteLine($"A área do retângulo é: {area3}");