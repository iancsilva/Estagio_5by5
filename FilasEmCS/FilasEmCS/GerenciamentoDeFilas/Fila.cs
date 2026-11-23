public class Fila
{
    public Senha? Head { get; set; } = null;
    public Senha? Tail { get; set; } = null;

    public void InserirSenha(Senha senha)
    {
        if (EstaVazia())
        {
            this.Head = senha;
            this.Tail = senha;
        }
        else
        {
            this.Tail.Proxima = senha;
            this.Tail = senha;
        }
    }

    public String? RetirarSenha()
    {
        string? retorno = this.Head.Valor;
        this.Head = this.Head.Proxima;

        return retorno;
    }

    public bool EstaVazia()
    {
        if (this.Head == null)
        {
            return true;
        }
        return false;
    }
}