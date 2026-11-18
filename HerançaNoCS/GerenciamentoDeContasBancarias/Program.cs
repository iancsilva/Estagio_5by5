ContaCorrente CriarContaCorrente()
{

    Console.WriteLine("Informe o número da sua conta:");
    int numeroDaConta = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o seu saldo atual:");
    int saldo = int.Parse(Console.ReadLine());

    return new ContaCorrente(numeroDaConta, saldo);

}

ContaPoupanca CriarContaPoupanca()
{

    Console.WriteLine("Informe o número da sua conta:");
    int numeroDaConta = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o seu saldo atual:");
    int saldo = int.Parse(Console.ReadLine());

    return new ContaPoupanca(numeroDaConta, saldo);

}

ContaSalario CriarContaSalario()
{

    Console.WriteLine("Informe o número da sua conta:");
    int numeroDaConta = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o seu saldo atual:");
    int saldo = int.Parse(Console.ReadLine());

    return new ContaSalario(numeroDaConta, saldo);

}

ContaCorrente Conta1 = new ContaCorrente(123, 3000);
ContaPoupanca Conta2 = new ContaPoupanca(456, 1500);
ContaSalario Conta3 = new ContaSalario(789, 137);

void TestarContas()
{
    Console.WriteLine(Conta1.ToString());
    Console.WriteLine();
    Conta1.Depositar(5200);
    Conta1.Sacar(2000);
    Conta1.Pagar(500);
    Console.WriteLine(Conta1.ToString());
    Console.WriteLine();

    Console.WriteLine(Conta2.ToString());
    Console.WriteLine();
    Conta2.Depositar(5200);
    Conta2.Sacar(2000);
    Conta2.Pagar(500);
    Console.WriteLine(Conta2.ToString());
    Console.WriteLine();

    Transferir(Conta1, Conta2, 750);
    Console.WriteLine(Conta2.ToString());

    Console.WriteLine(Conta3.ToString());
    Console.WriteLine();
    Conta3.Depositar(5200);
    Conta3.Sacar(2000);
    Conta3.Pagar(500);
    Console.WriteLine(Conta3.ToString());
    Console.WriteLine();

}

void Transferir(ContaCorrente conta1, ContaPoupanca conta2, int valorTransferido)
{
    conta1.Depositar(conta2.Transferir(valorTransferido));
    Console.WriteLine($"A conta de numero {conta2.NumeroDaConta} transferiu R$ {valorTransferido} para conta de número {conta1.NumeroDaConta}");
}

TestarContas();