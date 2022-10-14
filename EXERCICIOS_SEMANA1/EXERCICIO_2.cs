using System;
class Exercicio_2 {
  static void Main() {
      int horas_aula_prof1 = 0, horas_aula_prof2 = 0;
      double valor_hora_prof1 = 0, valor_hora_prof2 = 0, salario1 = 0, salario2 = 0;
        Console.WriteLine("Qual professor recebe mais. \n");
        Console.WriteLine("Horas aulas dada pelo professor 1:");
        horas_aula_prof1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor da aula do professor 1:");
        valor_hora_prof1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Horas aulas dada pelo professor 2:");
        horas_aula_prof2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor da aula do professor 2:");
        valor_hora_prof2 = double.Parse(Console.ReadLine());
        salario1 = horas_aula_prof1 * valor_hora_prof1;
        salario2 = horas_aula_prof2 * valor_hora_prof2;
        Console.WriteLine("Salário 1:" + salario1);
        Console.WriteLine("Salário 1:" + salario2);
        if(salario1 > salario2){
            Console.WriteLine("O professor 1 recebe mais.");
        }else if(salario1 < salario2){
            Console.WriteLine("O professor 2 recebe mais.");
        }else{
            Console.WriteLine("Os professores recebem o mesmo valor.");
        }
        
  }
}