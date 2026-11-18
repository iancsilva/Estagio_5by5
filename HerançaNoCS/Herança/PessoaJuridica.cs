public class PessoaJuridica : Pessoa
{
    public string Alias { get; set; }
    public string CNPJ { get; set; }

    public PessoaJuridica(string n, string c) : base(n)
    {
        CNPJ = c;
    }

    public PessoaJuridica(string n, string c, string? a) : base(n)
    {
        CNPJ = c;
        if (string.IsNullOrEmpty(a)) a = Nome;
        Alias = a;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nAlias: {this.Alias}\nCNPJ: {this.CNPJ}";
    }

}