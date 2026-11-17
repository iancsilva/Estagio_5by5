int materias = 5;
int colunas = 7;

object[,] boletim = new object[materias + 1, colunas];

void preencheBoletim()
{
    preencherCamposPreEstabelecidos();

    for (int l = 1; l < materias + 1; l++)
    {
        for (int c = 1; c < colunas; c++)
        {
            if (c < 5)
            {
                boletim[l, c] = gerarNota();

            }
            else if (c == 5)
            {
                boletim[l, c] = calcularMedias((float)boletim[l, 1], (float)boletim[l, 2], (float)boletim[l, 3], (float)boletim[l, 4]);

            }
            else if(c == 6)
            {
                boletim[l, c] = calcularStatus((float)boletim[l, 5]);
            }
        }
    }
}

void preencherCamposPreEstabelecidos()
{
    boletim[1, 0] = "Port";
    boletim[2, 0] = "Mat";
    boletim[3, 0] = "Hist";
    boletim[4, 0] = "Geo";
    boletim[5, 0] = "Cienc";

    boletim[0, 1] = "Nota 1";
    boletim[0, 2] = "Nota 2";
    boletim[0, 3] = "Nota 3";
    boletim[0, 4] = "Nota 4";
    boletim[0, 5] = "Média";
    boletim[0, 6] = "Status";
}

float gerarNota()
{
    return (float)Math.Round(Random.Shared.NextDouble() * 10, 2);
}

float calcularMedias(float nota1, float nota2, float nota3, float nota4)
{
    return (float)Math.Round((nota1 + nota2 + nota3 + nota4) / 4, 2);
}

string calcularStatus(float media)
{
    switch (media)
    {
        case >= 7:
            return "Aprovado";
        case < 7:
            return "Reprovado";
        default:
            return "Indefinido";
    }
}

void exibeBoletim()
{
    for (int l = 0; l < materias + 1; l++)
    {
        for (int c = 0; c < colunas; c++)
        {
            if (l == 0 && c == 0)
            {
                Console.Write("\t");
                continue;
            }
            Console.Write($"{boletim[l, c]} \t");
        }
        Console.WriteLine();
    }
}


preencheBoletim();
exibeBoletim();