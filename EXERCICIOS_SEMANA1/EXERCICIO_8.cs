using System;
class Exercicio_8 {
  static void Main() {
      double valorCompra = 0, lucro = 0;
    Console.WriteLine("Calculo de lucro de um comerciante. \n");
    Console.WriteLine("Digite o valor da compra R$: ");
    valorCompra = double.Parse(Console.ReadLine());
    if(valorCompra < 10){
        lucro = valorCompra * 0.7;
        Console.WriteLine("Lucro de 70% ou R$" + lucro + " reais.");
    }else if(valorCompra >= 10 && valorCompra < 30){
        lucro = valorCompra * 0.5;
        Console.WriteLine("Lucro de 50% ou R$" + lucro + " reais.");
    }else if(valorCompra >= 30 && valorCompra < 50){
        lucro = valorCompra * 0.4;
        Console.WriteLine("Lucro de 40% ou R$" + lucro + " reais.");
    }else if(valorCompra > 50){
        lucro = valorCompra * 0.3;
        Console.WriteLine("Lucro de 30% ou R$" + lucro + " reais.");
    }
  }
}