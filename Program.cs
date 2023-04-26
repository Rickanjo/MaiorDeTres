// Receba três números inteiros. Exiba somente o maior dos 3.
Console.WriteLine("--- Maior dos 3 ---");

Console.Write("Digite o primeiro número......:");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo número.......:");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write("Digite o terceiro número......:");
int num3 = int.Parse(Console.ReadLine()!);

int maior = num1;

if (num2 > maior) {
    maior = num2;
}

if (num3 > maior) {
    num3 = maior;
}
Console.WriteLine($"O maior número é {maior}");