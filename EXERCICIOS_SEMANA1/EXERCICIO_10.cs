using System;
class Exercicio_10 {
  static void Main() {
    int numero = 0;
    Console.WriteLine("Calculando a tabuada de um número. (1 - 9) \n");
    Console.WriteLine("Digite o número desejado: ");
    numero = int.Parse(Console.ReadLine());
    if((numero >= 1) && (numero <= 9)){
            Console.WriteLine("Tabuada de " + numero + "\n");
            Console.WriteLine(numero + " x 1: " + numero);
            Console.WriteLine(numero + " x 2: " + (numero * 2));
            Console.WriteLine(numero + " x 3: " + (numero * 3));
            Console.WriteLine(numero + " x 4: " + (numero * 4));
            Console.WriteLine(numero + " x 5: " + (numero * 5));
            Console.WriteLine(numero + " x 6: " + (numero * 6));
            Console.WriteLine(numero + " x 7: " + (numero * 7));
            Console.WriteLine(numero + " x 8: " + (numero * 8));
            Console.WriteLine(numero + " x 9: " + (numero * 9));
    }else{
        Console.WriteLine("Número inválido.");
    }
  }
}