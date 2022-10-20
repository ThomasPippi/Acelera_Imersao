using System;
class Vetor_01 {
  static void Main() {
      int i, par = 0, impar = 0;
      int[] vetor = new int[10];
    Console.WriteLine("Lendo valores em um vetor e mostrando quantidade de Ímpares e Pares.\n");
    for(i = 0; i < 10; i++){
        Console.WriteLine("Digite o valor do indice " + i + " do vetor.");
        vetor[i] = int.Parse(Console.ReadLine());
        if(vetor[i] % 2 == 0){
            par = par + 1;
        }else{
            impar = impar + 1;
        }
    }
    Console.WriteLine(par + " são pares.");
    Console.WriteLine(impar + " são ímpares.");
    
  }
}