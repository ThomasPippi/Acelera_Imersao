using System;
class EXERCICIO_20 {
  static void Main() {
    double dividendo = 1000, divisor = 1, resultado;
    int i;
    Console.WriteLine("Calculando e exibindo os 50 primeiros números. \n");
    for(i = 0; i <= 50; i++){
        resultado = dividendo / divisor;
        Console.WriteLine(resultado);
        dividendo = dividendo - 3;
        divisor = divisor + 1;
    }
  }
}