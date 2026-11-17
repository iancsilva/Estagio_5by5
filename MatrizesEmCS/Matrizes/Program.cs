using System.Security.Cryptography;

int[,] matriz1 = new int[2, 3];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Digite o valor para a posição [{i},{j}]: ");
        matriz1[i, j] = RandomNumberGenerator.GetInt32(1, 6);
    }
}