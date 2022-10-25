using System;
class Matriz_01 {
  static void Main() {
    Console.WriteLine("Exercícios de Matriz\n");
    int[,] Matriz = new int[5,3];
    int i, j;
    for(i = 0; i < 5; i++){
        Console.WriteLine("Digite os valores da primeira coluna:");
        Matriz[i, 0] = int.Parse(Console.ReadLine());
    }
    for(i = 0; i < 5; i++){
        Matriz[i, 1] = Matriz[i, 0] + 10;
        Console.WriteLine("Os valores da segunda coluna são: " + Matriz[i, 1]);
    }
    for(i = 0; i < 5; i++){
        Matriz[i, 2] = Matriz[i, 0] * 2;
        Console.WriteLine("Os valores da terceira coluna são: " + Matriz[i, 2]);
    }
  }
}