public abstract class ContaBancaria
{
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(int numeroDaConta, double saldoInicial)
    {
        this.NumeroDaConta = numeroDaConta;
        this.Saldo = saldoInicial;
    }

    public virtual void Depositar(double valorDepositado)
    {
        this.Saldo += valorDepositado;
    }
    public virtual double Sacar(double valorSacado)
    {
        if(valorSacado <= this.Saldo) 
        { 
            this.Saldo -= valorSacado;
            return valorSacado;
        }
        else return 0;
    }
    public virtual double Transferir(double valorTransferido)
    {
        return Sacar(valorTransferido);
    }
    public virtual double Pagar(double valorPago)
    {
        return Sacar(valorPago);
    }

    public override string ToString()
    {
        return $"Número da conta: {this.NumeroDaConta} \nSaldo: {this.Saldo}";
    }
}




