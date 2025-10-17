double peso, altura, imc;

Console.Write("--- Calculadora de IMC ---" +
                  "\nDigite sua altura (em m): ");
altura = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite seu peso (em kg): ");
peso = Convert.ToDouble(Console.ReadLine());

imc = peso / (altura * altura);
Console.WriteLine($"Seu IMC é: {imc.ToString("F2")}");
if (imc < 18.5)
    Console.WriteLine("Classificação: Abaixo do peso");
else if (imc >= 18.5 && imc < 24.9)
    Console.WriteLine("Classificação: Peso normal");
else if (imc >= 25 && imc < 29.9)
    Console.WriteLine("Classificação: Sobrepeso");
else if (imc >= 30 && imc < 34.9)
    Console.WriteLine("Classificação: Obesidade grau I");
else if (imc >= 35 && imc < 39.9)
    Console.WriteLine("Classificação: Obesidade grau II");
else
    Console.WriteLine("Classificação: Obesidade grau III (mórbida)");