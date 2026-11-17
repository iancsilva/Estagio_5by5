using System.Security.Cryptography;

Console.WriteLine("Digite a quantidade de linhas:");
int linhas = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de colunas:");
int colunas = int.Parse(Console.ReadLine());

int[,] matriz = new int[linhas, colunas];

Console.WriteLine("\nPreenchendo a matriz e exibindo");

for (int i = 0; i < linhas; i++)
{
    for (int j = 0; j < colunas; j++)
    {
        if (j == 0) Console.WriteLine();
        matriz[i, j] = RandomNumberGenerator.GetInt32(1, 10);
        Console.Write($"[{matriz[i, j]}]");
    }
}

Console.WriteLine("\n\nExibindo a matriz de trás para frente:\n");

for (int i = linhas - 1; i >= 0; i--)
{
    for (int j = colunas - 1; j >= 0; j--)
    {
        if (j == colunas - 1) Console.WriteLine();
        Console.Write($"[{matriz[i, j]}]");
    }
}