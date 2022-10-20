using System;
class EXEMPLO3 {
  static void Main() {
    int i;
    double[] notas = new double[5];
    double media = 0;
    Console.WriteLine(" - Leitura de Valores - \n");
    for(i = 0; i < 5; i++){
        Console.WriteLine("Digite a nota do aluno "+ i + ":");
        notas[i] = double.Parse(Console.ReadLine());
        media += notas[i];
    }
    media = media / 5;
    
    Console.WriteLine("A media de notas é: " + media);
  }
}
