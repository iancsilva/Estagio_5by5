Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

if (idade < 12) {
    Console.WriteLine("Criança");
} else if (idade >= 12 && idade < 18) {
    Console.WriteLine("Adolescente");
} else if (idade >= 18 && idade < 60) {
    Console.WriteLine("Adulto");
} else {
    Console.WriteLine("Idoso");
}
