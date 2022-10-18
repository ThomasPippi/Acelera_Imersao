using System;
class HelloWorld {
  static void Main() {
      int i;
    for (i = 0; i < 10; i++){
        if (i == 5 || i == 7){
            continue;
        }else{
            Console.WriteLine("Volta numero :"+i);
        }
    }
  }
}
