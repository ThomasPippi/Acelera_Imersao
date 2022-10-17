using System;
class EXERCICIO_12 {
  static void Main() {
    int inicio = 0, fim = 0, par = 0, soma = 0, i;
    Console.WriteLine("Soma dos números pares contidos no intervalo inserido. \n");
    Console.WriteLine("Digite o início do intervalo: ");
    inicio = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o fim do intervalo: ");
    fim = int.Parse(Console.ReadLine());
    for(i = inicio; i <= fim; i++){
        par = i % 2;
        if(par == 0){
            soma = i + soma;
        }
    }
    Console.WriteLine("A soma total dos números pares no intervalo de " + inicio +" e " + fim + " é: " + soma);
  }
}