using System;
class HelloWorld {
  static void Main() {
      int i;
    for (i = 0; i < 10; i++){
        Console.WriteLine("Volta numero :"+i);
        if (i == 5){
            break;
        }
    }
  }
}
