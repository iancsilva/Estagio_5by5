public class Motor
{
    public string Combustivel;
    public double Cilindrada;
    public double Potencia;

    public Motor(string combustivel, double cilindrada, double potencia)
    {
        this.Combustivel = combustivel;
        this.Cilindrada = cilindrada;
        this.Potencia = potencia;
    }

    public string GetCombustivel()
    {
        return this.Combustivel;
    }

    public double GetCilindrada()
    {
        return this.Cilindrada;
    }

    public double GetPotencia()
    {
        return this.Potencia;
    }
}