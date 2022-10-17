using System;
class Exercicio_3 {
  static void Main() {
      int mes = 0;
      Console.WriteLine("Mês correspondente ao número digitado \n");
      Console.WriteLine("Digite um número entre 1 e 12");
      mes = int.Parse(Console.ReadLine());
      if(mes > 0 && mes <= 12){
         switch(mes){
              case 1:
              Console.WriteLine(mes + " Corresponde a Janeiro.");
              break;
              case 2:
              Console.WriteLine(mes + " Corresponde a Fevereiro.");
              break;
              case 3:
              Console.WriteLine(mes + " Corresponde a Março.");
              break;
              case 4:
              Console.WriteLine(mes + " Corresponde a Abril.");
              break;
              case 5:
              Console.WriteLine(mes + " Corresponde a Maio.");
              break;
              case 6:
              Console.WriteLine(mes + " Corresponde a Junho.");
              break;
              case 7:
              Console.WriteLine(mes + " Corresponde a Julho.");
              break;
              case 8:
              Console.WriteLine(mes + " Corresponde a Agosto.");
              break;
              case 9:
              Console.WriteLine(mes + " Corresponde a Setembro.");
              break;
              case 10:
              Console.WriteLine(mes + " Corresponde a Outubro.");
              break;
              case 11:
              Console.WriteLine(mes + " Corresponde a Novembro.");
              break;
              case 12:
              Console.WriteLine(mes + " Corresponde a Dezembro.");
              break;
          }
      }else{
          Console.WriteLine("Número digitado inválido!");
      }
  }
}
