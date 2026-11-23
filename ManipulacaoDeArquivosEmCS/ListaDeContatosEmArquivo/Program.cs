var path = @"C:\ListaDeContatos\";
var file = "Contatos.txt";
var filePath = path + file;

if (!File.Exists(filePath))
{
    Directory.CreateDirectory(path);
    File.Create(filePath).Close();

}

void CriarContato()
{
    Console.WriteLine("\nInforme o nome do contato: ");
    string nome = Console.ReadLine();
    
    Console.WriteLine("\nInforme o número do contato: ");
    string numero = Console.ReadLine();

    string contato = $"\n{nome} \t | \t {numero}";

    if(File.ReadAllText(filePath) == "") File.AppendAllText(filePath, "\nNome: \t\t   \t Número: \n");

    File.AppendAllText(filePath, contato);
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
            string lista = File.ReadAllText(filePath);
            if (lista != "") Console.WriteLine(lista);
            else Console.WriteLine("\nA lista está vazia\n");
            break;

        case 3:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("\nNão entendi. Tente de novo\n");
            break;
    }
}