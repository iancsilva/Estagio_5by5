Console.WriteLine("Digite o valor do primeiro lado");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo lado");
float lado2 = float.Parse(Console.ReadLine());

float min = 0;
float max = lado1 + lado2;

if (lado1 >= lado2) {
    min = lado1 - lado2;
} else {
    min = lado2 - lado1;
}

Console.WriteLine("Digite o valor do terceiro lado");
Console.WriteLine("Atenção: o valor do terceiro lado deve ser maior que " + min + " e menor que " + max);
float lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3) {
    Console.WriteLine("Equilátero");
} else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3) {
    Console.WriteLine("Isósceles");
} else {
    Console.WriteLine("Escaleno");
}