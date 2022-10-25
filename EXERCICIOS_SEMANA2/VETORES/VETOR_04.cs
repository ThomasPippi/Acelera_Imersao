using System;
class Vetor_04 {
  static void Main() {
    int[] VetorA = new int[5];
    int[] VetorB = new int[5];
    int[] VetorMulti = new int[5];
    int i;
    Console.WriteLine("Multiplicando valores do mesmo indice de dois vetores e mostrando em um terceiro.\n");
    Console.WriteLine("Valores do primeiro vetor: ");
    for(i = 0; i < 5; i++){
        Console.WriteLine("Digite o valor do indice " + i + ".");
        VetorA[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Valores do segundo vetor: ");
    for(i = 0; i < 5; i++){
        Console.WriteLine("Digite o valor do indice " + i + ".");
        VetorB[i] = int.Parse(Console.ReadLine());
    }
    for(i = 0; i < 5; i++){
        VetorMulti[i] = VetorA[i] * VetorB[i];
        Console.WriteLine("A multiplicação dos dois vetores na posição " + i + " é igual a " + VetorMulti[i]);
    }
    
  }
}