using System;
class Exercicio_6 {
  static void Main() {
      int hora = 24, minuto = 60, segundo = 60;
    Console.WriteLine("Exibindo o horário definido!\n");
    while(hora >= 24){
        Console.WriteLine("Digite a hora: ");
        hora = int.Parse(Console.ReadLine());
        if(hora >= 24){
            Console.WriteLine(hora + " horas não é válido. Digite uma hora válida! \n");
        }
    }
    while(minuto >= 60){
        Console.WriteLine("Digite os minutos: ");
        minuto = int.Parse(Console.ReadLine());
        if(minuto >= 60){
            Console.WriteLine(minuto + " minutos não é válido. Digite um minuto válido! \n");
        }
    }
    while(segundo >= 60){
        Console.WriteLine("Digite os segundos: ");
        segundo = int.Parse(Console.ReadLine());
        if(segundo >= 60){
            Console.WriteLine(segundo + " segundos não é válido. Digite um segundo válido! \n");
        }
    }
    if(hora < 24 || minuto < 60 || segundo < 60){
        Console.WriteLine("Agora são: " + hora + ":" + minuto + ":" + segundo);
    }
  }
}
