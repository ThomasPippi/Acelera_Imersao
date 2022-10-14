using System;
class HelloWorld {
  static void Main() {
      int i, alunos;
      double nota1, nota2, nota3, media;
        Console.WriteLine("Média dos alunos. \n");
        Console.WriteLine("Digite a quantidade de alunos:");
        alunos = int.Parse(Console.ReadLine());
        for(i = 0; i < alunos; i++){
            Console.WriteLine("Digite a NOTA 1:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a NOTA 2:");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a NOTA 3:");
            nota3 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;
            if(media >= 7){
                Console.WriteLine("\n Média: " + media);
                Console.WriteLine("Aluno APROVADO");
            }else{
                Console.WriteLine("\n Média: " + media);
                Console.WriteLine("Aluno REPROVADO");
            }
        }
        
        
  }
}