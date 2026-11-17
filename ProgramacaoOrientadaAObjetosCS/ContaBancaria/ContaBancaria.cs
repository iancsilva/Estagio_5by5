public class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public ContaBancaria(string titular, double saldo)
    {
        this.Titular = titular;
        this.Saldo = saldo;
    }

    public void Depositar(double valorDepositado)
    {
        this.Saldo += Math.Round(valorDepositado, 2);
    }

    public void Sacar(double valorSacado)
    {
        this.Saldo -= Math.Round(valorSacado, 2);
    }

    public string ExibirSaldo()
    {
        return $"R$ {Math.Round(this.Saldo, 2)}";
    }

    public override string ToString()
    {
        return $"\nTitular: {this.Titular} \nSaldo: {ExibirSaldo()}\n";
    }
}