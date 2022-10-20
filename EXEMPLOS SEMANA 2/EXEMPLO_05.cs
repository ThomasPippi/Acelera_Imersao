using System;
class EXEMPLO3 {
  static void Main() {
    int i, j;
    int[,] A = new int[3,4];
    for(i = 0; i < 3; i++){
        for(j = 0; j < 4; j++){
            Console.WriteLine("A[" + i + "," + j + "] = " + A[i, j]);
        }
    }
    
  }
}