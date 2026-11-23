public class Contato(string nome, string telefone, char genero)
{
    //public int Id { get; set; }
    public string Nome { get; private set; } = nome;
    public string Telefone { get; set; } = telefone;
    public char Genero { get; set; } = genero;


}