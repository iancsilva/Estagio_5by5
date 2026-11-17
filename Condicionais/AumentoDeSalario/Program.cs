Console.WriteLine("Digite seu salário");
double salario = double.Parse(Console.ReadLine());

if (salario <= 2000) {
    salario *= 1.15;
} else if (salario > 2000 && salario < 4000) {
    salario *= 1.10;
} else {
    salario *= 1.05;
}

Console.WriteLine("Seu novo salário é: " + salario);