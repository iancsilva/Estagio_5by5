public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }
    public string Mobile { get; set; }
    public char Genero { get; set; }

    public PessoaFisica(string cpf, string nome) : base(nome)
    {
        CPF = cpf;
    }

    public PessoaFisica(string cpf, string nome, string p) : base(nome, p)
    {
        CPF = cpf;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nCPF: {this.CPF}\nMobile: {this.Mobile}\nGênero: {this.Genero}";
    }

}