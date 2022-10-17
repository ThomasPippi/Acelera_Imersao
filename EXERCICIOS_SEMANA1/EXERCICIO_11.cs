using System;
class EXERCICIO_11{
  static void Main() {
      int i, resto;
    Console.WriteLine("Gerando números entre 1000 e 1999 com resto da divisão sendo 5. \n");
    for(i = 1000; i < 2000; i++){
        resto = i % 11;
        if(resto == 5){
            Console.WriteLine(i);
        }
    }
  }
}