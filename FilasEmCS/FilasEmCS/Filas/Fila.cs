public class Fila
{
    public Pessoa Head { get; set; }
    public Pessoa Tail { get; set; }
    public int Contador { get; set; }

    public Fila()
    {
        this.Head = this.Tail = null;
        this.Contador = 0;
    }

    public bool FilaVazia()
    {
        if (this.Head == null) return true;
        return false;
    }

    public void InserirElemento(Pessoa aux)
    {
        if (FilaVazia())
        {
            this.Head = aux;
            this.Tail = aux;
        }
        else
        {
            this.Tail.Proximo = aux;
            this.Tail = aux;
        }
        this.Contador++;
    }

    public int GetarContador()
    {
        return this.Contador;
    }

    public void RemoverItem()
    {
        if (!FilaVazia())
        {
            this.Head = this.Head.Proximo;
            this.Contador--;
        }
        else
        {
            this.Head = this.Tail = null;
        }
    }

    public void MostrarFila()
    {
        Pessoa p = this.Head;

        for(int i = 1; i <= this.Contador; i++)
        {
            if(i < this.Contador) Console.Write(p.Nome + " => ");
            if(i == this.Contador) Console.Write(p.Nome);
            p = p.Proximo;
        }
    }
}