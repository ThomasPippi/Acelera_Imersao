using System;
class Matriz_04 {
  static void Main() {
            int[,] Matriz = new int[5, 5];
            int par = 0, pares = 0, impar = 0, positivo = 0, negativo = 0, zero = 0;
            int i, j;
            Console.WriteLine("Exercício de Matriz - Pares, Impares, Positivos e Negativos.");
            for(i = 0; i < 5; i++)
            {
                for(j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite o valor de [" + i + ", " + j + "]:");
                    Matriz[i, j] = int.Parse(Console.ReadLine());
                    par = Matriz[i, j] % 2;
                    if(par == 0)
                    {
                        pares++;
                    }else if(par != 0){
                        impar++;
                    }
                    if(Matriz[i, j] > 0)
                    {
                        positivo++;
                    }else if(Matriz[i, j] < 0)
                    {
                        negativo++;
                    }
                    else
                    {
                        zero++;
                    }
                }
            }
            Console.WriteLine("Pares: " + pares);
            Console.WriteLine("Ímpares: " + impar);
            Console.WriteLine("Positivos: " + positivo);
            Console.WriteLine("Negativos: " + negativo);
            Console.WriteLine("Zeros: " + zero);
  }
}