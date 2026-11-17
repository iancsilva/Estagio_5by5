Console.WriteLine("Digite o lado da matriz quadrada ");
int lado = int.Parse(Console.ReadLine());

int[,] matriz = new int[lado, lado];

void PreencherEExibirMatriz()
{
    for (int i = 0; i < lado; i++)
    {
        for (int j = 0; j < lado; j++)
        {
            if (j == 0) Console.WriteLine();
            matriz[i, j] = Random.Shared.Next(1, 11);
            Console.Write($"[{matriz[i, j]}]");
        }
    }
}

void somaDasLinhas()
{
    Console.WriteLine("\n\nSoma das linhas da matriz:\n");
    for (int i = 0; i < lado; i++)
    {
        int somaLinha = 0;
        for (int j = 0; j < lado; j++)
        {
            somaLinha += matriz[i, j];
        }
        Console.WriteLine($"Soma da linha {i + 1}: {somaLinha}");
    }
}

void somaDasColunas()
{
    Console.WriteLine("\nSoma das colunas da matriz:\n");
    for (int i = 0; i < lado; i++)
    {
        int somaColuna = 0;
        for (int j = 0; j < lado; j++)
        {
            somaColuna += matriz[j, i];
        }
        Console.WriteLine($"Soma da coluna {i + 1}: {somaColuna}");
    }
}

void somaDasDiagonais()
{
    int somaDiagonalPrincipal = 0;
    int somaDiagonalInversa = 0;
    for (int i = 0; i < lado; i++)
    {
        somaDiagonalPrincipal += matriz[i, i];
        somaDiagonalInversa += matriz[i, lado - 1 - i];
    }
    Console.WriteLine($"\nSoma da diagonal principal: {somaDiagonalPrincipal}");
    Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalInversa}");
}

PreencherEExibirMatriz();
somaDasLinhas();
somaDasColunas();
somaDasDiagonais();