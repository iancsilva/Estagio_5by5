public class Pilha
{
    public Dinheiro? Head { get; set; }

    public void DepositarDinheiro(Dinheiro novoValor)
    {
        novoValor.Proximo = this.Head;
        this.Head = novoValor;
    }

    public int SacarDinheiro()
    {
        int retorno = this.Head.Valor;
        this.Head = this.Head.Proximo;
        return retorno;
    }

    public bool EstaVazio()
    {
        return this.Head == null;
    }

    public void ExibirPilha()
    {
        Dinheiro? atual = this.Head;
        while(atual != null)
        {
            Thread.Sleep(500);
            Console.WriteLine($"\n {atual.Valor}");
            atual = atual.Proximo;
        }
    }
}
