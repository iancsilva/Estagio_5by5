using System.Security.Cryptography;

int[,] matriz = new int[3,5];

Console.WriteLine("Preenchendo a matriz com valores aleatórios entre 1 e 10:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if(j == 0) Console.WriteLine();
        matriz[i, j] = RandomNumberGenerator.GetInt32(1, 10);
        Console.Write($"[{matriz[i, j]}]");
    }
}

Console.WriteLine("\n\nMatriz inversa:\n");

int[,] matrizInversa = new int[5,3];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (j == 0) Console.WriteLine();
        matrizInversa[i, j] = matriz[j, i];
        Console.Write($"[{matrizInversa[i, j]}]");
    }
}