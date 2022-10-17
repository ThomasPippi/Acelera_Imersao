using System;
class EXERCICIO_15 {
  static void Main() {
      int i;
    Console.WriteLine("Tabela de conversão de POLEGADAS para CENTÍMETROS. \n");
    for(i = 1; i <= 20; i++){
        Console.WriteLine(i +" polegadas equivalem a: " + (i / 2.54) + " centimetros.");
    }    
  }
}