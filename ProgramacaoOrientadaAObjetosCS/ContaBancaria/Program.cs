ContaBancaria CriarConta()
{
    Console.WriteLine("Informe seu nome:");
    string nome = Console.ReadLine();

    Console.WriteLine("\nInforme seu saldo atual:");
    double saldo = double.Parse(Console.ReadLine());

    ContaBancaria conta = new ContaBancaria(nome, saldo);

    Console.WriteLine(conta.ToString());

    return conta;
}

void Depositar(ContaBancaria conta)
{
    Console.WriteLine("\nInforme o valor que deseja depositar: ");
    double valorDepositado = double.Parse(Console.ReadLine());
    conta.Depositar(valorDepositado);
    Console.WriteLine($"\nVocê depositou R$ {Math.Round(valorDepositado, 2)}");
    Console.WriteLine($"Seu saldo atual é {conta.ExibirSaldo()}");
}

void Sacar(ContaBancaria conta)
{
    Console.WriteLine("\nInforme o valor que deseja sacar:");
    double valorSacado = double.Parse(Console.ReadLine());
    conta.Sacar(valorSacado);
    Console.WriteLine($"\nVocê sacou R$ {Math.Round(valorSacado, 2)}");
    Console.WriteLine($"Seu saldo atual é {conta.ExibirSaldo()}");
}

ContaBancaria Conta1 = CriarConta();
Depositar(Conta1);
Sacar(Conta1);