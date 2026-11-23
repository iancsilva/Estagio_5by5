public class Dinheiro
{
    public int Valor { get; set; }
    public Dinheiro? Proximo { get; set; }

    public Dinheiro(int valor = 100)
    {
        this.Valor = valor;
    }

}