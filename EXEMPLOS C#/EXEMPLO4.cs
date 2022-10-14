using System;
class HelloWorld {
  static void Main() {
      int i, valor1, valor2;
    Console.WriteLine("Mostrando o intervalo entre dois valores inteiros. \n");
    Console.WriteLine("Digite o Valor 1:");
    valor1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o Valor 2:");
    valor2 = int.Parse(Console.ReadLine());
    for (i = valor1+1; i < valor2; i++){
        Console.WriteLine(i);
    }
    
  }
}