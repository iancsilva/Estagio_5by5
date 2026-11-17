Livro CriarLivro()
{
    Console.WriteLine("Informe o título do livro:");
    string titulo = Console.ReadLine();

    Console.WriteLine("\nInforme o nome do autor:");
    string autor = Console.ReadLine();

    Console.WriteLine("\nInforme o número de páginas do livro:");
    int numeroDePaginas = int.Parse(Console.ReadLine());

    while (numeroDePaginas < 1)
    {
        Console.WriteLine("\nO número de páginas não pode ser menor que 1. Tente novamente:");
        numeroDePaginas = int.Parse(Console.ReadLine());
    }

    Livro livro = new Livro(titulo, autor, numeroDePaginas);

    Console.WriteLine();
    Console.WriteLine(livro.ToString());

    return livro;
}

Livro Livro1 = CriarLivro();

