
Carro[] carros = CriarConjuntoDeCarros();
Carro CriarCarro(int numeroDoCarro)
{
    Console.WriteLine($"\n--------------------- Carro {numeroDoCarro} ---------------------");

    Console.WriteLine($"\nInsira o fabricante do carro {numeroDoCarro}: ");
    string fabricante = Console.ReadLine();

    Console.WriteLine($"\nInsira o modelo do carro {numeroDoCarro}: ");
    string modelo = Console.ReadLine();

    Console.WriteLine($"\nInsira o ano de fabricação do carro {numeroDoCarro}: ");
    int anoDeFabricacao = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nInsira o ano do modelo do carro {numeroDoCarro}: ");
    int anoDoModelo = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nInsira o valor de venda do carro {numeroDoCarro}: ");
    double valorDeVenda = double.Parse(Console.ReadLine());

    Console.WriteLine("\n----------------- Motor -----------------");

    Console.WriteLine($"\nInsira o tipo do combustível do carro {numeroDoCarro}: ");
    string tipoDeCombustivel = Console.ReadLine();

    Console.WriteLine($"\nInsira a cilindrada do carro {numeroDoCarro}: ");
    double cilindrada = double.Parse(Console.ReadLine());

    Console.WriteLine($"\nInsira a potência do carro {numeroDoCarro}: ");
    double potencia = double.Parse(Console.ReadLine());

    Console.WriteLine();

    return new Carro(fabricante, modelo, anoDeFabricacao, anoDoModelo, valorDeVenda, tipoDeCombustivel, cilindrada, potencia);

}

Carro[] CriarConjuntoDeCarros()
{
    Console.WriteLine("Informe quantos carros deseja criar: ");
    int numeroDeCarros = int.Parse(Console.ReadLine());

    Carro[] conjunto = new Carro[numeroDeCarros];

    for (int carro = 0; carro < numeroDeCarros; carro++)
    {
        conjunto[carro] = CriarCarro(carro + 1);
    }

    return conjunto;
}

void ExibirCarros(int numeroDeCarros)
{
    for (int carro = 0; carro < numeroDeCarros; carro++)
    {
        Console.WriteLine($"\nCarro {carro + 1}:\n");
        Console.WriteLine(carros[carro].ToString());
        Console.WriteLine();
    }
}

ExibirCarros(carros.Length);

void CalcularIPVA()
{
    Console.WriteLine("\nInforme o número do carro que deseja calcular o IPVA:");
    int numeroDoCarro = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nInforme a UF do estado para o IPVA do carro {numeroDoCarro} (ex.: SP, MG, RJ...): ");
    string estado = Console.ReadLine().ToUpperInvariant();

    double aliquota = 0.00;

    switch (estado)
        {
            case "AC":
                aliquota = 2.00;
                break;
            case "AL":
                aliquota = 3.00;
                break;
            case "AP":
                aliquota = 3.00;
                break;
            case "AM":
                aliquota = 3.00;
                break;
            case "BA":
                aliquota = 2.50;
                break;
            case "CE":
                aliquota = 3.00;
                break;
            case "DF":
                aliquota = 3.50;
                break;
            case "ES":
                aliquota = 2.00;
                break;
            case "GO":
                aliquota = 3.75;
                break;
            case "MA":
                aliquota = 2.50;
                break;
            case "MT":
                aliquota = 2.00;
                break;
            case "MS":
                aliquota = 3.00;
                break;
            case "MG":
                aliquota = 4.00;
                break;
            case "PA":
                aliquota = 2.50;
                break;
            case "PB":
                aliquota = 2.50;
                break;
            case "PR":
                aliquota = 3.50;
                break;
            case "PE":
                aliquota = 2.40;
                break;
            case "PI":
                aliquota = 2.50;
                break;
            case "RJ":
                aliquota = 4.00;
                break;
            case "RN":
                aliquota = 3.00;
                break;
            case "RS":
                aliquota = 3.00;
                break;
            case "RO":
                aliquota = 2.00;
                break;
            case "RR":
                aliquota = 3.00;
                break;
            case "SC":
                aliquota = 2.00;
                break;
            case "SP":
                aliquota = 4.00;
                break;
            case "SE":
                aliquota = 2.50;
                break;
            case "TO":
                aliquota = 2.00;
                break;
            default:
                aliquota = 0.00;
                break;
        }

    double valorDoIpva = carros[numeroDoCarro - 1].ValorDeVenda * aliquota / 100;
    Console.WriteLine($"\nIPVA do {carros[numeroDoCarro -1].Fabricante} {carros[numeroDoCarro - 1].Modelo} ({estado}) com alíquota de {aliquota/100}%: R$ {Math.Round(valorDoIpva, 2)}");
    
}

CalcularIPVA();