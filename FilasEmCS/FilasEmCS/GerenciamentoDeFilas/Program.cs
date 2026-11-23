Fila FilaComum = new Fila();
Fila FilaPrioritaria = new Fila();

int RetiradasDaFilaPrioritaria = 0;

void InserirSenha(bool ehPrioritario)
{
    if (ehPrioritario) { FilaPrioritaria.InserirSenha(new Senha(ehPrioritario)); }
    else { FilaComum.InserirSenha(new Senha(ehPrioritario)); }

}

string? RetirarSenha()
{
    if (!FilaPrioritaria.EstaVazia() && RetiradasDaFilaPrioritaria < 2)
    {
        RetiradasDaFilaPrioritaria++;
        return $"\n{FilaPrioritaria.RetirarSenha()}";
    }
    else if (!FilaComum.EstaVazia())
    {
        RetiradasDaFilaPrioritaria = 0;
        return $"\n{FilaComum.RetirarSenha()}";
    }
    RetiradasDaFilaPrioritaria = 0;
    return "As filas estão vazias!";
}

void Execucao()
{
    while (true)
    {
        Console.WriteLine("Deseja inserir ou retirar uma senha? I = inserir, R = retirar");
        char Operacao = char.Parse(Console.ReadLine());

        if (Operacao == 'I')
        {
            Console.WriteLine("\nA senha é para a fila de prioridade? S/N");
            char EhPrioridade = char.Parse(Console.ReadLine());

            if (EhPrioridade == 'S')
            {
                InserirSenha(true);
                Console.WriteLine("\nA senha com prioridade foi criada e inserida na fila com sucesso!");
            }
            else if (EhPrioridade == 'N')
            {
                InserirSenha(false);
                Console.WriteLine("\nA senha comum foi criada e inserida na fila com sucesso!");
            }
            else
            {
                Console.WriteLine("\nHouve algum erro na inserção, provavelmente de digitação no campo anterior!");
            }
        }
        else if (Operacao == 'R')
        {
            Console.WriteLine($"\n{RetirarSenha()}");
        }
        else
        {
            Console.WriteLine("\nHouve algum erro na seleção, provavelmente erro de digitação no campo anterior!");
            Thread.Sleep(1500);
        }

        Console.WriteLine();
    }
}

Execucao();