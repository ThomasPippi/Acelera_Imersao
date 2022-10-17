using System;
class Exercicio_9 {
  static void Main() {
    double ladoA = 0, ladoB = 0, ladoC = 0;
    Console.WriteLine("Verificando possibilidade de um triângulo com base em seus lados. \n");
    Console.WriteLine("Digite o valor do lado A: ");
    ladoA = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor do lado B: ");
    ladoB = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor do lado C: ");
    ladoC = double.Parse(Console.ReadLine());
    if(((ladoA + ladoB) > ladoC) && ((ladoA + ladoC) > ladoB) && ((ladoB + ladoC) > ladoA)){
        if((ladoA == ladoB) && (ladoA == ladoC)){
            Console.WriteLine("\nEsses lados formam um triângulo EQUILÁTERO. ");
        }else if((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC)){
            Console.WriteLine("\nEsses lados formam um triângulo ISÓSCELES.");
        }else{
            Console.WriteLine("\nEsses lados formam um triângulo ESCALENO.");
        }
    }else{
        Console.WriteLine("\nNão formam um triângulo.");
    }
  }
}