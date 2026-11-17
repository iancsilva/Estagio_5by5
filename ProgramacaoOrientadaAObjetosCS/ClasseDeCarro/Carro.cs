class Carro
{
    public string Fabricante;
    public string Modelo;
    public int AnoDeFabricacao;
    public int AnoDoModelo;
    public double ValorDeVenda;
    public Motor Motor;

    public Carro(string fabricante, string modelo, int anoDeFabricacao, int anoDoModelo, double valorDeVenda, string tipoDeCombustivel, double cilindrada, double potencia)
    {
        this.Fabricante = fabricante;
        this.Modelo = modelo;
        this.AnoDeFabricacao = anoDeFabricacao;
        this.AnoDoModelo = anoDoModelo;
        this.ValorDeVenda = valorDeVenda;
        this.Motor = new Motor(tipoDeCombustivel, cilindrada, potencia);
    }

    public override string ToString()
    {
        return $"Fabricante: {this.Fabricante} " +
               $"\nModelo: {this.Modelo} " +
               $"\nAno de fabricação: {this.AnoDeFabricacao} " +
               $"\nAno do modelo: {this.AnoDoModelo} " +
               $"\nValor de venda: {Math.Round(this.ValorDeVenda, 2)} " +
               $"\n\n------- Motor -------\n" +
               $"\nCombustível: {this.Motor.GetCombustivel()} " +
               $"\nCilindrada: {Math.Round(this.Motor.GetCilindrada(), 2)} " +
               $"\nPotência: {Math.Round(this.Motor.GetPotencia(), 2)} ";
    }
}