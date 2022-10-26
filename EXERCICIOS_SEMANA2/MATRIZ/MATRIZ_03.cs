using System;
class Matriz_03 {
  static void Main() {
    int[,] Matriz = new int[4, 4];
            int i, j;
            Console.WriteLine("Exercício de Matriz - Diagonal Principal");
            for(i = 0; i < 4; i++)
            {
                for(j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite o valor de [" + i + "," + j + "]");
                    Matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("A diagonal principal possui: " 
                + Matriz[0, 0] + ", "
                + Matriz[1, 1] + ", "
                + Matriz[2, 2] + ", "
                + Matriz[3, 3] + ", ");
  }
}