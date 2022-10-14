using System;
class HelloWorld {
  static void Main() {
      int opcao, i;
      i = 0;
      opcao = 0;
        Console.WriteLine("Entre 1 e 4. \n");
        while(i == 0){
            Console.WriteLine("Digite um número:");
            opcao = int.Parse(Console.ReadLine());
            if(opcao > 4 || opcao < 1){
                continue;
            }else{
                i = 1;
                Console.WriteLine("Fim do laço. \n");
                break;
            }
        }
        
        switch(opcao){
            case 1:
            Console.WriteLine("Primeira Opção.");
            break;
            case 2:
            Console.WriteLine("Segunda Opção.");
            break;
            case 3:
            Console.WriteLine("Terceira Opção.");
            break;
            case 4:
            Console.WriteLine("Quarta Opção.");
            break;
        }
        
        
        
  }
}