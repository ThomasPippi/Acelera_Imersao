using System;
class EXERCICIO_21 {
  static void Main() {
    int numero, i, resultado = 0;
    Console.WriteLine("Verificando se o número inserido é primo ou não.\n");
    Console.WriteLine("Digite o número desejado: ");
    numero = int.Parse(Console.ReadLine());
    for (i = 2; i <= (numero / 2); i++) {
        if (numero % i == 0) {
        resultado++;
        break;
        }
    }
    if (resultado == 0)
        Console.WriteLine(numero + " é um número primo.");
    else
        Console.WriteLine(numero + " não é um número primo.");
  }
}