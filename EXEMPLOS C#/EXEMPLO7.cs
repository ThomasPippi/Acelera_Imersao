using System;
class HelloWorld {
  static void Main() {
      int i, valor;
        Console.WriteLine("Mostrando os numeros de 0 a 100 que são divisíveis por X. \n");
        Console.WriteLine("Digite o Valor de X:");
        valor = int.Parse(Console.ReadLine());
        for(i = 0; i < 100; i++){
            if(i % valor == 0){
                Console.WriteLine(i);
            }
        }
        
  }
}