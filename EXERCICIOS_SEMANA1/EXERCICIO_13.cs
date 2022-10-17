using System;
class EXERCICIO_13 {
  static void Main() {
    int inicio = 0, fim = 0, escolha = 0, i;
    Console.WriteLine("Mostrando os pares ou ímpares entre um intervalo inserido.\n");
    Console.WriteLine("Insira o valor inicial do intervalo: ");
    inicio = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o valor final do intervalo: ");
    fim = int.Parse(Console.ReadLine());
    Console.WriteLine("Escolha se quer pular os pares ou ímpares selecionando com os números 1 ou 2.");
    while(escolha == 0 || escolha > 2){
        Console.WriteLine("1- Pular Ímpares.\n2 - Pular Pares.");
        escolha = int.Parse(Console.ReadLine());
    }
    if(escolha == 1){ 
        for(i = inicio; i <= fim; i++){
            if((i % 2) == 0)
            Console.WriteLine(i);
        }
    }else if(escolha == 2){
        for(i = inicio; i <= fim; i++){
            if((i % 2) != 0)
            Console.WriteLine(i);
        }
    }
  }
}