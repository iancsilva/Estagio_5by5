Livro CriarLivro(int numeroDeLivros)
{
    Console.WriteLine($"\nInforme o título do livro {numeroDeLivros}:");
    string titulo = Console.ReadLine();

    Console.WriteLine($"\nInforme o nome do autor do livro {numeroDeLivros}:");
    string autor = Console.ReadLine();

    Console.WriteLine($"\nInforme o número de páginas do livro {numeroDeLivros}:");
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

Livro[] CriarConjuntoDeLivros()
{
    Console.WriteLine("Informe quantos livros deseja criar: ");
    int numeroDeLivros = int.Parse(Console.ReadLine());

    Livro[] conjunto = new Livro[numeroDeLivros];

    for (int livro = 0; livro < numeroDeLivros; livro++)
    {
        conjunto[livro] = CriarLivro(livro + 1);
    }

    return conjunto;
}

Livro[] livros = CriarConjuntoDeLivros();

void ExibirLivros(int numeroDeLivros)
{
    for (int livro = 0; livro < numeroDeLivros; livro++)
    {
        Console.WriteLine($"\nLivro {livro + 1}:\n");
        Console.WriteLine(livros[livro].ToString());
        Console.WriteLine();
    }
}

ExibirLivros(livros.Length);