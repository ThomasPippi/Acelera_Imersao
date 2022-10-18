using System;
class EXERCICIO_17 {
  static void Main() {
      int i, inicio = 0, fim = 0, escolha = 0;
    Console.WriteLine("Mostrando todos os valores dentro do intervalo definido. \n");
    Console.WriteLine("Digite o valor inicial: ");
    inicio = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor final: ");
    fim = int.Parse(Console.ReadLine());
    Console.WriteLine("Escolha se quer os valores exibidos de forma CRESCENTE OU DECRESCENTE.\n");
    while(escolha == 0 || escolha > 2){
        Console.WriteLine("1 - Crescente. \n2 - Decrescente.");
        escolha = int.Parse(Console.ReadLine());
    }
    if(escolha == 1){
        for(i = inicio; i <= fim; i++){
        Console.WriteLine(i);
        }
    }else if(escolha == 2){
        for(i = fim; i >= inicio; i--){
        Console.WriteLine(i);
        }
    }
  }
}