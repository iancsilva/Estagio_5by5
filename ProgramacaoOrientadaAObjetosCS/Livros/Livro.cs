class Livro
{
    public string Titulo;
    public string Autor;
    public int NumeroDePaginas;

    public Livro(string titulo, string autor, int numeroDePaginas)
    {
        this.Titulo = titulo;
        this.Autor = autor;
        this.NumeroDePaginas = numeroDePaginas;
    }

    public string GetTitulo()
    {
        return this.Titulo;
    }
    public string GetAutor()
    {
        return this.Autor;
    }
    public int GetNumeroDePaginas()
    {
        return this.NumeroDePaginas;
    }
    public override string ToString()
    {
        return $"Título: {GetTitulo()} \nAutor: {GetAutor()} \nNúmero de páginas: {GetNumeroDePaginas()}";
    }
}