var path = @"C:\ListaDeContatos\";
var file = "Contatos.txt";
var filePath = path + file;

if (!File.Exists(filePath))
{
    Directory.CreateDirectory(path);
    File.Create(filePath).Close();
    File.WriteAllText(filePath, "\nNome:   \t\t   Número: \n");

}

void CriarContato()
{
    Console.WriteLine("\nInforme o nome do contato: ");
    string nome = Console.ReadLine();
    
    Console.WriteLine("\nInforme o número do contato: ");
    string numero = Console.ReadLine();

    string contato = $"\n{nome} \t | \t {numero}";

    var writer = new StreamWriter(filePath, true);
    
    writer.WriteLine(contato);

    writer.Close();
}

while (true)
{
    Console.WriteLine("\n1 - Criar novo contato \n2 - Exibir contatos \n3 - Sair");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CriarContato();
            break;
            
        case 2:
            var reader = new StreamReader(filePath);
            string lista = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(lista);
            break;

        case 3:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("\nNão entendi. Tente de novo\n");
            break;
    }
}