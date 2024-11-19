using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite algukma coisa no teclado:");

    // exemplo 1
    //Capturando a entrada do usuario
    string entrada = Console.ReadLine();

    //Exibindo o que o usuario digitou

    Console.WriteLine("Você digitou: " + entrada);

    //Exempo 2 -------------------
    Console.WriteLine("*******************");
    // Capturando o primeiro valor
    Console.WriteLine("Digite o primeiro valor:");
    string valor1 = Console.ReadLine();
    int numero1 = int.Parse(valor1);

    //segundo valor
    Console.WriteLine("Digite o segundo valor:");
    string valor2 = Console.ReadLine();
    int numero2 = int.Parse(valor2);

    // calculando a soma
    int soma = numero1 + numero2;

    // Exibindo o resultado
    Console.WriteLine("A soma dos valores é: " + soma);
  }
}