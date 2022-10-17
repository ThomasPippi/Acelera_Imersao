using System;
class EXERCICIO_5{
  static void Main() {
    string entrada;
    Console.WriteLine("Digite uma letra: ");
    entrada = Console.ReadLine();
    if(entrada == "A" || entrada == "E" || entrada == "I" || entrada == "O" || entrada == "U" || entrada == "a" ||
    entrada == "e" ||entrada == "i" ||entrada == "o" ||entrada == "u"){
        Console.WriteLine("Vogal!");
    }else{
        Console.WriteLine("Consoante!");
    }
  }
}
