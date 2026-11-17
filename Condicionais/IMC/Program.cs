Console.WriteLine("Digite seu peso em kg");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura em cm");
float altura = float.Parse(Console.ReadLine());

float imc = peso / ((altura / 100) * (altura / 100));

Console.WriteLine("IMC: " + imc);

if (imc < 16) {
    Console.WriteLine("Magreza grau III");

} else if (imc >= 16 && imc < 17) {
    Console.WriteLine("Magreza grau II");

} else if (imc >= 17 && imc < 18.5) {
    Console.WriteLine("Magreza grau I");

} else if (imc >= 18.5 && imc < 25) {
    Console.WriteLine("Peso normal");

} else if (imc >= 25 && imc < 30) {
    Console.WriteLine("Sobrepeso");

} else if(imc >= 30 && imc < 35) {
    Console.WriteLine("Obesidade grau I");

} else if (imc >= 35 && imc < 40) {
    Console.WriteLine("Obesidade grau II");

} else {
    Console.WriteLine("Obesidade grau III");

}