using System;
class HelloWorld {
  static void Main() {
      int i, valor;
        Console.WriteLine("Mostrando os numeros de 0 a 100 pulando de X declarado. \n");
        Console.WriteLine("Digite o Valor:");
        valor = int.Parse(Console.ReadLine());
        for (i = 0; i <= 100; i+=valor){
            Console.WriteLine(i);
        }
    
  }
}