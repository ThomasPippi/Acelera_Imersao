using System;
class EXEMPLO2 {
  static void Main() {
    int i;
    int[] b = new int[5];
    Console.WriteLine("- Leitura de Valores - \n");
    for(i = 0; i < 5; i++){
        Console.WriteLine("Digite o valor " + i + ":");
        b[i] = int.Parse(Console.ReadLine());
    }
    for(i = 0; i < 5; i++){
        Console.WriteLine("O valor índice de " + i + " é igual a " + b[i]);
    }
  }
}
