using System;
class Exercicio_7 {
  static void Main() {
    double renda_Bruta = 0, renda_Percapita = 0;
    int integrantes;
    Console.WriteLine("Calculando a renda per capita de uma família. \n");
    Console.WriteLine("Digite o valor da renda bruta da família R$: ");
    renda_Bruta = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o número de integrantes na família: ");
    integrantes = int.Parse(Console.ReadLine());
    renda_Percapita = renda_Bruta / integrantes;
    Console.WriteLine("A renda per capita da família é de R$" + renda_Percapita);
  }
}