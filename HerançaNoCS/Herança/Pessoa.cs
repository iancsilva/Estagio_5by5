public abstract class Pessoa
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public DateOnly Data { get; set; }
    public string Telefone { get; set; }

    public Pessoa(string n)
    {
        Nome = n;
        Data = DateOnly.FromDateTime(DateTime.Now);
    }

    public Pessoa(string n, string p)
    {
        Nome = n;
        Telefone = p;
    }

    public override string ToString()
    {
        return $"Nome: {this.Nome}\nEndereço: {this.Endereco}\nData: {this.Data}\nTelefone: {this.Telefone}";
    }

}