Console.WriteLine("Digite o primeiro número");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um dos seguintes operadores: +, -, *, /");
string operador = Console.ReadLine();

int resultado;

switch (operador) {
    case "+":
        resultado = numero1 + numero2;
        Console.WriteLine(numero1 + operador + numero2 + " = " + resultado);
        break;

    case "-":
        resultado = numero1 - numero2;
        Console.WriteLine(numero1 + operador + numero2 + " = " + resultado);
        break;

    case "*":
        resultado = numero1 * numero2;
        Console.WriteLine(numero1 + operador + numero2 + " = " + resultado);
        break;

    case "/":
        if (numero2 != 0) {
            resultado = numero1 / numero2;
            Console.WriteLine(numero1 + operador + numero2 + " = " + resultado);
        }
        else {
            Console.WriteLine("Não é possível dividir por zero.");
        }
        break;
}
