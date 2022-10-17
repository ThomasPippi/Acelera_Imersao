using System;
class EXERCICIO_16 {
  static void Main() {
      int i, inicio = 0, fim = 0;
    Console.WriteLine("Mostrando todos os valores dentro do intervalo definido. \n");
    Console.WriteLine("Digite o valor inicial: ");
    inicio = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor final: ");
    fim = int.Parse(Console.ReadLine());
    for(i = inicio; i <= fim; i++){
        Console.WriteLine(i);
    }
  }
}