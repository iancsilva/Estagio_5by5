public class ContaCorrente : ContaBancaria
{
    public double Limite
    {
        get;
        set
        {
            if (this.Saldo >= 0) { field = value; }
            else { field = this.Saldo; }
        }
    }

    public ContaCorrente(int numeroDaConta, double saldoInicial) : base(numeroDaConta, saldoInicial)
    {
        this.Limite = saldoInicial * 3;
    }

    public override void Depositar(double valorDepositado)
    {
        this.Limite = (this.Saldo += valorDepositado) * 3;
    }
    public override double Sacar(double valorSacado)
    {
        if(valorSacado <= this.Limite)
        {
            this.Saldo -= valorSacado;
            this.Limite = (this.Saldo) * 3;
            return valorSacado;
        }
        else return 0;
    }
    public override double Transferir(double valorTransferido)
    {
        return Sacar(valorTransferido);
    }
    public override double Pagar(double valorPago)
    {
        return Sacar(valorPago);
    }
    public override string ToString()
    {
        return $"{base.ToString()} \nLimite: {this.Limite}";
    }

}