Console.WriteLine("Digite a primeira nota");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota");
float nota4 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media >= 7) {
    Console.WriteLine("Média: " + media);
    Console.WriteLine("Aprovado");
} else if (media >= 5 && media < 7) {
    Console.WriteLine("Média: " + media);
    Console.WriteLine("Recuperação");
} else {
    Console.WriteLine("Média: " + media);
    Console.WriteLine("Reprovado");

}
