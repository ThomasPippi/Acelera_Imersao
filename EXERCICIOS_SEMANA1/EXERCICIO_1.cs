using System;
class Exercicio_1 {
  static void Main() {
      int n1 = 0, n2 = 0, n3 = 0, n4 = 0, media = 7;      
        Console.WriteLine("Caldular média e imprimir superiores a média 7. \n");
        Console.WriteLine("Digite o valor da nota 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da nota 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da nota 3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da nota 4: ");
        n4 = int.Parse(Console.ReadLine());
        media = (n1 + n2 + n3 + n4) / 4;
        if(n1 > media){
            Console.WriteLine(n1 + " é maior que a MÉDIA. \n");
        }
        if(n2 > media){
            Console.WriteLine(n2 + " é maior que a MÉDIA. \n");
        }
        if(n3 > media){
            Console.WriteLine(n3 + " é maior que a MÉDIA. \n");
        }
        if(n4 > media){
            Console.WriteLine(n4 + " é maior que a MÉDIA. \n");
        }
  }
}
