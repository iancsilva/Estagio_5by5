var path = @"C:\dev\";
var file = "dados.dat";

bool PathValidation(string p)
{
    //if (Directory.Exists(p))
    //    return true;

    try
    {
        Directory.CreateDirectory(p);
        return true;
    }
    catch (DirectoryNotFoundException e)
    {
        Console.WriteLine(e);
        return false;
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return false;
    }

}

bool FileValidation(string p)
{
    if (File.Exists(p + file))
        return true;
    try
    {
        if (PathValidation(p))
        {
            File.Create(p + file).Close();
            return true;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return false;
    }
    return false;
}

void ShowPhrases()
{
    var reader = new StreamReader(path + file);
    //while (reader.Read() != -1)
    //{
    //    Console.WriteLine(reader.ReadLine());
    //}
    Console.WriteLine(reader.ReadToEnd());

    reader.Close();
}

void AddPhrase(string s)
{
    if (FileValidation(path))
    {
        var reader = new StreamReader(path + file);

        //var x = reader.ReadLine();
        //var y = reader.ReadLine();

        var phrases = new List<string>();

        string aux = reader.ReadLine();

        while (aux is not null)
        {
            //reader.Read();
            aux = reader.ReadLine();
            phrases.Add(aux);

        } 

        phrases.Add(s);

        reader.Close();

        var writer = new StreamWriter(path + file);

        foreach (var item in phrases)
        {
            writer.WriteLine(item);
        }

        writer.Close();

        //foreach (var item in phrases)
        //{
        //    phrases.Add(item);
        //}
    }
}

int MainMenu()
{
    Console.WriteLine("1 - Adicionar frase no arquivo.");
    Console.WriteLine("2 - Mostrar frases do arquivo.");
    Console.WriteLine("0 - Sair.");
    return int.Parse(Console.ReadLine());
}

while (true)
{
    switch (MainMenu())
    {
        case 1:
            Console.WriteLine("Informe sua frase desmotivacional: ");
            AddPhrase(Console.ReadLine());
            break;
        case 2:
            try
            {
                ShowPhrases();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            break;
        case 0:
            Console.WriteLine("Hasta la vista, baby!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Não entendi!");
            break;
    }
}
