Pilha PilhaDeDinheiro = new Pilha();

void Executar()
{
    while (true)
    {

        Console.WriteLine("Qual ação deseja realizar? \n1 - Empilhar dinheiro \n2 - Tirar dinheiro \n3 - Exibir pilha");
        int? Opcao = int.Parse(Console.ReadLine());

        switch (Opcao)
        {
            case 1:

                Console.WriteLine("\nQual o valor a ser empilhado?");
                int Valor = int.Parse(Console.ReadLine());
                PilhaDeDinheiro.DepositarDinheiro(new Dinheiro(Valor));
                break;

            case 2:

                Console.WriteLine($"\n{PilhaDeDinheiro.SacarDinheiro()}");
                break;

            case 3:

                PilhaDeDinheiro.ExibirPilha();
                break;

            default:

                Console.WriteLine($"\nTu fez parada errada irmão, reveja isso aí!");
                break;
        }

        Console.WriteLine();

    }
}

Executar();