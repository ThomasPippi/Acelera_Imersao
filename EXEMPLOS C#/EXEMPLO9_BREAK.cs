using System;
class HelloWorld {
  static void Main() {
      int n = 1;
        Console.WriteLine("Laço infinito até 0. \n");
        while(n != 0){
            Console.WriteLine("Digite N:");
            n = int.Parse(Console.ReadLine());
            if(n == 0){
                break;
            }
        }
        
        
  }
}