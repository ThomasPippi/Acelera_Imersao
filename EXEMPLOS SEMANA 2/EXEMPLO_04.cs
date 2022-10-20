using System;
class EXEMPLO3 {
  static void Main() {
    int i, maior;
    int[] vetor = new int[10];
    for(i = 0; i < 10; i++){
        Console.WriteLine("Digite o elemento " + i + " do vetor: ");
        vetor[i] = int.Parse(Console.ReadLine());
    }
    maior = vetor[0];
    for(i = 0; i < 0; i++){
        if(maior < vetor[i]){
            maior = vetor[i];
        }
    }
  }
}