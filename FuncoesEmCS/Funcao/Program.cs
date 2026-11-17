bool verificaNumeroPrimo(int numero)
{
    if (numero <= 1)
        return false;
    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
            return false;
    }
    return true;
}

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

for (int n = 1; n <= numero; n++)
{
    bool ehPrimo = verificaNumeroPrimo(n);

    if (ehPrimo)
    {
        Console.WriteLine(n);
    }
}