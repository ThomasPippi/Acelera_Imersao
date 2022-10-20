using System;
class Vetor_02 {
  static void Main() {
      int[] vetorA = new int[5]; //Exercício pede 20 de cada mas para execução, usando 5.
      int[] vetorB = new int[5];
      int[] somaVetor = new int[5];
      int i;
      Console.WriteLine("Digite os valores do primeiro Vetor.\n");
      for(i = 0; i < 5; i++){
          Console.WriteLine("Valor " + i + ":");
          vetorA[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("\nValores lidos com Sucesso!");
      Console.WriteLine("\nDigite os valores do segundo Vetor.");
      for(i = 0; i < 5; i++){
          Console.WriteLine("Valor " + i + ":");
          vetorB[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("\nValores lidos com Sucesso!");
      for(i = 0; i < 5; i++){
          somaVetor[i] = (vetorA[i] + vetorB[i]);
          Console.WriteLine("A soma dos vetores " + vetorA[i] + " e " + vetorB[i] + " = " + somaVetor[i]);
      }
  }
}