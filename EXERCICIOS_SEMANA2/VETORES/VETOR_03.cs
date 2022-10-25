using System;
class Vetor_03 {
  static void Main() {
    int i, impar;
    int[] Vetor = new int[5];
    Console.WriteLine("Lendo valores e mostrando o índice dos que são Ímpares.");
    for(i = 0; i < 5; i++){
        Console.WriteLine("Digite o número.");
        Vetor[i] = int.Parse(Console.ReadLine());
        impar = Vetor[i] % 2;
        if(impar != 0){
            Console.WriteLine("O número localizado no índice " + i + " do vetor é impar.");
        }
    }
  }
}