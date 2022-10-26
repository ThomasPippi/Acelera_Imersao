using System;
class Matriz_05 {
  static void Main() {
    double[,] matrizA = new double[2, 3];
            double[,] matrizB = new double[2, 3];
            double[,] matrizSoma = new double[2, 3];
            int i, j;
            Console.WriteLine("Soma de duas matrizes DOUBLE.\n");
            Console.WriteLine("Digite os valores da PRIMEIRA matriz: ");
            for(i = 0; i < 2; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite [" + i + "," + j + "]:");
                    matrizA[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Agora, digite os valores da SEGUNDA matriz: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite [" + i + "," + j + "]:");
                    matrizB[i, j] = double.Parse(Console.ReadLine());
                    matrizSoma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("A soma das matrizes é: ");
                    Console.WriteLine(matrizSoma[i, j]);
                }
            }
  }
}